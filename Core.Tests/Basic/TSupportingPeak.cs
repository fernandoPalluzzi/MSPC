﻿// Licensed to the Genometric organization (https://github.com/Genometric) under one or more agreements.
// The Genometric organization licenses this file to you under the GNU General Public License v3.0 (GPLv3).
// See the LICENSE file in the project root for more information.

using Genometric.GeUtilities.IntervalParsers.Model.Defaults;
using Genometric.MSPC.Core.Model;
using Xunit;

namespace Genometric.MSPC.Core.Tests.Basic
{
    public class TSupportingPeak
    {
        [Fact]
        public void CompareWithANullObject()
        {
            // Arrange
            var sp = new SupportingPeak<ChIPSeqPeak>(new ChIPSeqPeak(), 1);

            // Act & Assert
            Assert.True(sp.CompareTo(null) == 1);
        }
    }
}
