﻿// Licensed to the Genometric organization (https://github.com/Genometric) under one or more agreements.
// The Genometric organization licenses this file to you under the GNU General Public License v3.0 (GPLv3).
// See the LICENSE file in the project root for more information.

using Genometric.GeUtilities.IGenomics;
using Genometric.MSPC.Model;
using Genometric.MSPC.XSquaredData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using static Genometric.MSPC.Core.Model.Messages;

namespace Genometric.MSPC.Core.Model
{
    public class ProcessedPeak<I> : Peak<I>, IComparable<ProcessedPeak<I>>
            where I : IChIPSeqPeak, new()
    {
        public ProcessedPeak(I source, double xSquared, List<SupportingPeak<I>> supportingPeaks) :
            this(source, xSquared, supportingPeaks.AsReadOnly())
        { }

        public ProcessedPeak(I source, double xSquared, ReadOnlyCollection<SupportingPeak<I>> supportingPeaks):
            base(source)
        {
            XSquared = xSquared;
            SupportingPeaks = supportingPeaks;
            if (double.IsNaN(xSquared))
                RTP = double.NaN;
            else
                RTP = ChiSquaredCache.ChiSqrdDistRTP(XSquared, 2 + (supportingPeaks.Count * 2));
            Classification = new HashSet<Attributes>();
        }

        /// <summary>
        /// Sets and gets X-squared of test
        /// </summary>
        public double XSquared { private set; get; }

        /// <summary>
        /// Right tailed probability of x-squared.
        /// </summary>
        public double RTP { private set; get; }
        
        public ReadOnlyCollection<SupportingPeak<I>> SupportingPeaks { private set; get; }

        /// <summary>
        /// Gets the reason of discarding this ER. It returns an empty string if 
        /// this ER is confirmed. 
        /// </summary>
        public string Reason { get { return Decode(reason); } }
        internal Codes reason = Codes.M000;

        /// <summary>
        /// Sets and gets classification type. 
        /// </summary>
        public HashSet<Attributes> Classification { internal set; get; }

        /// <summary>
        /// Sets and gets adjusted p-value using the multiple testing correction method of choice.
        /// </summary>
        public double AdjPValue { internal set; get; }

        int IComparable<ProcessedPeak<I>>.CompareTo(ProcessedPeak<I> other)
        {
            if (other == null) return 1;
            return CompareTo(other);
        }

        public override bool Equals(object obj)
        {
            return obj is ProcessedPeak<I> peak &&
                   EqualityComparer<I>.Default.Equals(Source, peak.Source) &&
                   XSquared == peak.XSquared &&
                   RTP == peak.RTP &&
                   !SupportingPeaks.Except(peak.SupportingPeaks).Any() &&
                   Reason == peak.Reason &&
                   !Classification.Except(peak.Classification).Any() &&
                   AdjPValue == peak.AdjPValue;
        }

        public override int GetHashCode()
        {
            string key = base.GetHashCode() + "_" + XSquared + "_" + RTP + "_" + SupportingPeaks.Count;
            int l = key.Length;

            int hashKey = 0;
            for (int i = 0; i < l; i++)
            {
                hashKey += key[i];
                hashKey += (hashKey << 10);
                hashKey ^= (hashKey >> 6);
            }

            hashKey += (hashKey << 3);
            hashKey ^= (hashKey >> 11);
            hashKey += (hashKey << 15);

            return hashKey;
        }

        public static bool operator >(ProcessedPeak<I> operand1, ProcessedPeak<I> operand2)
        {
            return operand1.CompareTo(operand2) == 1;
        }

        public static bool operator <(ProcessedPeak<I> operand1, ProcessedPeak<I> operand2)
        {
            return operand1.CompareTo(operand2) == -1;
        }

        public static bool operator >=(ProcessedPeak<I> operand1, ProcessedPeak<I> operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }

        public static bool operator <=(ProcessedPeak<I> operand1, ProcessedPeak<I> operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }

        public static bool operator ==(ProcessedPeak<I> operand1, ProcessedPeak<I> operand2)
        {
            if (operand1 is null)
                return operand2 is null;
            return operand1.Equals(operand2);
        }

        public static bool operator !=(ProcessedPeak<I> operand1, ProcessedPeak<I> operand2)
        {
            if (operand1 is null)
                return operand2 is null;
            return !operand1.Equals(operand2);
        }
    }
}
