﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Genometric.MSPC.XSquaredData
{
    internal class DF18
    {
        internal double ChiSqrd(double x)
        {
            if (x < 1500.0)
                return Data[(int)Math.Round(x)];
            else
                return 0.0;
        }

        private readonly double[] Data = new double[]
        {
             #region .     Data     .
1   ,
9.99999996564510E-01    ,
9.99998874797402E-01    ,
9.99972264180753E-01    ,
9.99762552671739E-01    ,
9.98859747167396E-01    ,
9.96197007938324E-01    ,
9.90126341943895E-01    ,
9.78636565512016E-01    ,
9.59742687517962E-01    ,
9.31906365278151E-01    ,
8.94356677807586E-01    ,
8.47237493984561E-01    ,
7.91573033190778E-01    ,
7.29091267738082E-01    ,
6.61967119141483E-01    ,
5.92547341437591E-01    ,
5.23105045032887E-01    ,
4.55652604322419E-01    ,
3.91823482544940E-01    ,
3.32819678750719E-01    ,
2.79413047862368E-01    ,
2.31985133167456E-01    ,
1.90590130086720E-01    ,
1.55027781767463E-01    ,
1.24916196944670E-01    ,
9.97579144835177E-02    ,
7.89954897721782E-02    ,
6.20551959003492E-02    ,
4.83790636383382E-02    ,
3.74464934796729E-02    ,
2.87871823494198E-02    ,
2.19872535490588E-02    ,
1.66903868897340E-02    ,
1.25955195069134E-02    ,
9.45240282652609E-03    ,
7.05600914749347E-03    ,
5.24051350624318E-03    ,
3.87334872728562E-03    ,
2.84964905532002E-03    ,
2.08725904913502E-03    ,
1.52238435872254E-03    ,
1.10589289337605E-03    ,
8.00231791852454E-04    ,
5.76901166622863E-04    ,
4.14414403499673E-04    ,
2.96672511322117E-04    ,
2.11683310775199E-04    ,
1.50562697629793E-04    ,
1.06763119082374E-04    ,
7.54826416470647E-05    ,
5.32158732773563E-05    ,
3.74151462320915E-05    ,
2.62365959961570E-05    ,
1.83510471012814E-05    ,
1.28039833117634E-05    ,
8.91242647922362E-06    ,
6.18938402055736E-06    ,
4.28876138043416E-06    ,
2.96537880073247E-06    ,
2.04607590427057E-06    ,
1.40891454671141E-06    ,
9.68268341850743E-07    ,
6.64172064456768E-07    ,
4.54740644274597E-07    ,
3.10791175402288E-07    ,
2.12039985580363E-07    ,
1.44421726114780E-07    ,
9.82049951964520E-08    ,
6.66715676237891E-08    ,
4.51931645745695E-08    ,
3.05877856366329E-08    ,
2.06720716668351E-08    ,
1.39507464011391E-08    ,
9.40165945099795E-09    ,
6.32733391730507E-09    ,
4.25266440056040E-09    ,
2.85456531443847E-09    ,
1.91368847111792E-09    ,
1.28135138993121E-09    ,
8.56927106414171E-10    ,
5.72414435195177E-10    ,
3.81926968647692E-10    ,
2.54545077126171E-10    ,
1.69462997921612E-10    ,
1.12699418175108E-10    ,
7.48713227339163E-11    ,
4.96897110281294E-11    ,
3.29446068364857E-11    ,
2.18211945528242E-11    ,
1.44397005337276E-11    ,
9.54623610645693E-12    ,
6.30534777394813E-12    ,
4.16099418603033E-12    ,
2.74349648301421E-12    ,
1.80733534078719E-12    ,
1.18961839615603E-12    ,
7.82381433800921E-13    ,
5.14136519329313E-13    ,
3.37593699171624E-13    ,
2.21499567299764E-13    ,
1.45218055531920E-13    ,
9.51357763086920E-14    ,
6.22800251185349E-14    ,
4.07419050551707E-14    ,
2.66334444953049E-14    ,
1.73985255237332E-14    ,
1.13580074989613E-14    ,
7.40972012887111E-15    ,
4.83077277191413E-15    ,
3.14739776956504E-15    ,
2.04932956772980E-15    ,
1.33352736980432E-15    ,
8.67214827946448E-16    ,
5.63625519993424E-16    ,
3.66098743899346E-16    ,
2.37658742698016E-16    ,
1.54191893099181E-16    ,
9.99828684339096E-17    ,
6.47962639770228E-17    ,
4.19699623740300E-17    ,
2.71703514691489E-17    ,
1.75801965530442E-17    ,
1.13691404445719E-17    ,
7.34870014823548E-18    ,
4.74761928339583E-18    ,
3.06568194804842E-18    ,
1.97864314049945E-18    ,
1.27643955285089E-18    ,
8.23054506596259E-19    ,
5.30463610639271E-19    ,
3.41730918732245E-19    ,
2.20048079679265E-19    ,
1.41631029533324E-19    ,
9.11191347608935E-20    ,
5.85967962543340E-20    ,
3.76663875146548E-20    ,
2.42020708392484E-20    ,
1.55443345273359E-20    ,
9.97965030326736E-21    ,
6.40449036960040E-21    ,
4.10849084659217E-21    ,
2.63457728196552E-21    ,
1.68877877935809E-21    ,
1.08210665352682E-21    ,
6.93114669898785E-22    ,
4.43792566899906E-22    ,
2.84051451589127E-22    ,
1.81743196273950E-22    ,
1.16242657932714E-22    ,
7.43226428852679E-23    ,
4.75036501813113E-23    ,
3.03518374366566E-23    ,
1.93863954125046E-23    ,
1.23784164153353E-23    ,
7.90116055342819E-24    ,
5.04169141634681E-24    ,
3.21605135123127E-24    ,
2.05084463472979E-24    ,
1.30739650376206E-24    ,
8.33198190328998E-25    ,
5.30832366034167E-25    ,
3.38092983404734E-25    ,
2.15271325634458E-25    ,
1.37027907998051E-25    ,
8.71979363209204E-26    ,
5.54726890029045E-26    ,
3.52800775773049E-26    ,
2.24315140698701E-26    ,
1.42583019263770E-26    ,
9.06063383925682E-27    ,
5.75615230114164E-27    ,
3.65586576742140E-27    ,
2.32131350013376E-27    ,
1.47354785123326E-27    ,
9.35153401797176E-28    ,
5.93322607997125E-28    ,
3.76347985479253E-28    ,
2.38660292521421E-28    ,
1.51308668766493E-28    ,
9.59050984915788E-29    ,
6.07736024138675E-29    ,
3.85021339928084E-29    ,
2.43866573585627E-29    ,
1.54425318743691E-29    ,
9.77652632749398E-30    ,
6.18801766687951E-30    ,
3.91579968799673E-30    ,
2.47737855390968E-30    ,
1.56699741318683E-30    ,
9.90944165542318E-31    ,
6.26521637726375E-31    ,
3.96031670221485E-31    ,
2.50283182091200E-31    ,
1.58140193548522E-31    ,
9.98993441396616E-32    ,
6.30948180681642E-32    ,
3.98415595462178E-32    ,
2.51530951664701E-32    ,
1.58766867246784E-32    ,
1.00194183997403E-32    ,
6.32179183146321E-33    ,
3.98798708824721E-33    ,
2.51526641077176E-33    ,
1.58610430155706E-33    ,
9.99994924959444E-34    ,
6.30351710869545E-34    ,
3.97271982231529E-34    ,
2.50330382878990E-34    ,
1.57710484993338E-34    ,
9.93412659876461E-35    ,
6.25635903930877E-35    ,
3.93946466787025E-35    ,
2.48014480765882E-35    ,
1.56114000152728E-35    ,
9.82499507241691E-36    ,
6.18228737324248E-36    ,
3.88949365090616E-36    ,
2.44660939758716E-36    ,
1.53873758235613E-36    ,
9.67594692584832E-37    ,
6.08347917330705E-37    ,
3.82420208476919E-37    ,
2.40359074235117E-37    ,
1.51046860742788E-37    ,
9.49062865217839E-38    ,
5.96226053758892E-38    ,
3.74507223657797E-38    ,
2.35203244663513E-38    ,
1.47693319473242E-38    ,
9.27285338947675E-39    ,
5.82105217665286E-39    ,
3.65363954202675E-39    ,
2.29290762009020E-39    ,
1.43874757778756E-39    ,
9.02652049829323E-40    ,
5.66231965505568E-40    ,
3.55146184494859E-40    ,
2.22719987740515E-40    ,
1.39653237980848E-40    ,
8.75554325726029E-41    ,
5.48852884501738E-41    ,
3.44009197644874E-41    ,
2.15588647402772E-41    ,
1.35090225117022E-41    ,
8.46378524657796E-42    ,
5.30210690780669E-42    ,
3.32105384576718E-42    ,
2.07992366967671E-42    ,
1.30245691822141E-42    ,
8.15500566106653E-43    ,
5.10540891780326E-43    ,
3.19582209255008E-43    ,
2.00023433708055E-43    ,
1.25177364599937E-43    ,
7.83281351759666E-44    ,
4.90069007595333E-44    ,
3.06580524809872E-44    ,
1.91769777149403E-44    ,
1.19940107994215E-44    ,
7.50063049533356E-45    ,
4.69008332272302E-45    ,
2.93233227085022E-45    ,
1.83314160702499E-45    ,
1.14585440195315E-45    ,
7.16166196894505E-46    ,
4.47558205397288E-46    ,
2.79664225764114E-46    ,
1.74733570784317E-46    ,
1.09161171360631E-46    ,
6.81887566108951E-47    ,
4.25902756402031E-47    ,
2.65987708561880E-47    ,
1.66098787489825E-47    ,
1.03711154320303E-47    ,
6.47498724668185E-48    ,
4.04210078564864E-48    ,
2.52307670815497E-48    ,
1.57474119065901E-48    ,
9.82751363042563E-49    ,
6.13245218276686E-49    ,
3.82631786385809E-49    ,
2.38717680979322E-49    ,
1.48917281433492E-49    ,
9.28886997850921E-50    ,
5.79346300926478E-50    ,
3.61302908554779E-50    ,
2.25300851812356E-50    ,
1.40479403680120E-50    ,
8.75832804031439E-51    ,
5.45995136240442E-51    ,
3.40342068794684E-51    ,
2.12129987256901E-51    ,
1.32205140678832E-51    ,
8.23862501493667E-52    ,
5.13359395956985E-52    ,
3.19851908150551E-52    ,
1.99267875953732E-52    ,
1.24132874667128E-52    ,
7.73210544569245E-53    ,
4.81582184712125E-53    ,
2.99919704537585E-53    ,
1.86767703854739E-53    ,
1.16294988635499E-53    ,
7.24073925287798E-54    ,
4.50783224752066E-54    ,
2.80618148308320E-54    ,
1.74673560325174E-54    ,
1.08718195635715E-54    ,
6.76614310484480E-55    ,
4.21060239523406E-55    ,
2.62006236033746E-55    ,
1.63021014341876E-55    ,
1.01423909542696E-55    ,
6.30960423343094E-56    ,
3.92490480934536E-56    ,
2.44130248428527E-56    ,
1.51837739775714E-56    ,
9.44286443202421E-57    ,
5.87210589618144E-57    ,
3.65132351199809E-57    ,
2.27024782227898E-57    ,
1.41144171200794E-57    ,
8.77444303922713E-58    ,
5.45435378573985E-58    ,
3.39027076354513E-58    ,
2.10713809714484E-58    ,
1.30954174121062E-58    ,
8.13792382601192E-59    ,
5.05680278342628E-59    ,
3.14200394591568E-59    ,
1.95211743393579E-59    ,
1.21275715884905E-59    ,
7.53374009956283E-60    ,
4.67968354712533E-60    ,
2.90664228387200E-60    ,
1.80524486945868E-60    ,
1.12111525822754E-60    ,
6.96200286510116E-61    ,
4.32302851149951E-61    ,
2.68418314852767E-61    ,
1.66650456988554E-61    ,
1.03459735256982E-61    ,
6.42254089396998E-62    ,
3.98669696004620E-62    ,
2.47451773805166E-62    ,
1.53581563309276E-62    ,
9.53144899743404E-63    ,
5.91493897437706E-63    ,
3.67039890284680E-63    ,
2.27744597643764E-63    ,
1.41304138076580E-63    ,
8.76665295045419E-64    ,
5.43857400857803E-64    ,
3.37371756059548E-64    ,
2.09269051235517E-64    ,
1.29799807064953E-64    ,
8.05037291087254E-65    ,
4.99264871625058E-65    ,
3.09613031450986E-65    ,
1.91990973636322E-65    ,
1.19046298159237E-65    ,
7.38116017481223E-66    ,
4.57622278763970E-66    ,
2.83702803310346E-66    ,
1.75870976623546E-66    ,
1.09018184329626E-66    ,
6.75737584817880E-67    ,
4.18824140209643E-67    ,
2.59573273081194E-67    ,
1.60865537701755E-67    ,
9.96875599078000E-68    ,
6.17723267414708E-68    ,
3.82756108849852E-68    ,
2.37151355051428E-68    ,
1.46927987496974E-68    ,
9.10246503638936E-69    ,
5.63883267632037E-69    ,
3.49297295448898E-69    ,
2.16360109256881E-69    ,
1.34009393306482E-69    ,
8.29983569045663E-70    ,
5.14020071323854E-70    ,
3.18322335236008E-70    ,
1.97120013764553E-70    ,
1.22059342057229E-70    ,
7.55767381065197E-71    ,
4.67931409365186E-71    ,
2.89703208166075E-71    ,
1.79350082997115E-71    ,
1.11026627082818E-71    ,
6.87274314911370E-72    ,
4.25412844321924E-72    ,
2.63310825316835E-72    ,
1.62968840219692E-72    ,
1.00859843994870E-72    ,
6.24180184583560E-73    ,
3.86260004353571E-73    ,
2.39016395667122E-73    ,
1.47895153355351E-73    ,
9.15079015359517E-74    ,
5.66163363542237E-74    ,
3.50270488508502E-74    ,
2.16692588696295E-74    ,
1.34048943982842E-74    ,
8.29204536939036E-75    ,
5.12907416692509E-75    ,
3.17245468822913E-75    ,
1.96214508941642E-75    ,
1.21351779752789E-75    ,
7.50482595642728E-76    ,
4.64103284742564E-76    ,
2.86991015198611E-76    ,
1.77460498928710E-76    ,
1.09727360587079E-76    ,
6.78434775000067E-77    ,
4.19451062160960E-77    ,
2.59319169028758E-77    ,
1.60312786822223E-77    ,
9.91019089452510E-78    ,
6.12599000134274E-78    ,
3.78661409349686E-78    ,
2.34048791073576E-78    ,
1.44657994799847E-78    ,
8.94044741933796E-79    ,
5.52531357204390E-79    ,
3.41456638435150E-79    ,
2.11006208255631E-79    ,
1.30387523586433E-79    ,
8.05671607310730E-80    ,
4.97807443632339E-80    ,
3.07571510395138E-80    ,
1.90025682932129E-80    ,
1.17397827855249E-80    ,
7.25252890534655E-81    ,
4.48023306354407E-81    ,
2.76753779208345E-81    ,
1.70949726884161E-81    ,
1.05590596350440E-81    ,
6.52174983752092E-82    ,
4.02796021794790E-82    ,
2.48764516437693E-82    ,
1.53629280803549E-82    ,
9.48728496506792E-83    ,
5.85857988461668E-83    ,
3.61763967448463E-83    ,
2.23378247229307E-83    ,
1.37923778511530E-83    ,
8.51569675108645E-84    ,
5.25755807642971E-84    ,
3.24586830999217E-84    ,
2.00382926199507E-84    ,
1.23701113554983E-84    ,
7.63606567140393E-85    ,
4.71355875563332E-85    ,
2.90945398891926E-85    ,
1.79579779154383E-85    ,
1.10837524232538E-85    ,
6.84068693622032E-86    ,
4.22178586653604E-86    ,
2.60541162305611E-86    ,
1.60783034089780E-86    ,
9.92174115348079E-87    ,
6.12236805502950E-87    ,
3.77776478667672E-87    ,
2.33095774601902E-87    ,
1.43819562493227E-87    ,
8.87331029633151E-88    ,
5.47441334164771E-88    ,
3.37733219390298E-88    ,
2.08350390602443E-88    ,
1.28528449643789E-88    ,
7.92845737398797E-89    ,
4.89060586546005E-89    ,
3.01662440495033E-89    ,
1.86064914516068E-89    ,
1.14760510402531E-89    ,
7.07791355449762E-90    ,
4.36518747190859E-90    ,
2.69206456824800E-90    ,
1.66017180018751E-90    ,
1.02377764921737E-90    ,
6.31311016389434E-91    ,
3.89283741536326E-91    ,
2.40034904402052E-91    ,
1.48002082903325E-91    ,
9.12528867838190E-92    ,
5.62614360296950E-92    ,
3.46865007362470E-92    ,
2.13843325889620E-92    ,
1.31830683871628E-92    ,
8.12686343170719E-93    ,
5.00973932568753E-93    ,
3.08811214553484E-93    ,
1.90351728025278E-93    ,
1.17329296441290E-93    ,
7.23172742253993E-94    ,
4.45721543661193E-94    ,
2.74707967152160E-94    ,
1.69303131739100E-94    ,
1.04338572581347E-94    ,
6.43000052114742E-95    ,
3.96244637461378E-95    ,
2.44175516124764E-95    ,
1.50462132225786E-95    ,
9.27125965686345E-96    ,
5.71263879628691E-96    ,
3.51982706931104E-96    ,
2.16866506267555E-96    ,
1.33613483169064E-96    ,
8.23179956612565E-97    ,
5.07137867023707E-97    ,
3.12423788470091E-97    ,
1.92463776252027E-97    ,
1.18560716585347E-97    ,
7.30330745047955E-98    ,
4.49868264694792E-98    ,
2.77101060082371E-98    ,
1.70678226893001E-98    ,
1.05124807347622E-98    ,
6.47469787082059E-99    ,
3.98768693914056E-99    ,
2.45589562847739E-99    ,
1.51246769296398E-99    ,
9.31428893468148E-100   ,
5.73588917350848E-100   ,
3.53215124098372E-100   ,
2.17503060343123E-100   ,
1.33930361565131E-100   ,
8.24670284225893E-101   ,
5.07772681378920E-101   ,
3.12641082448781E-101   ,
1.92491046465343E-101   ,
1.18512140175848E-101   ,
7.29630556256644E-102   ,
4.49191052025736E-102   ,
2.76533107906407E-102   ,
1.70235908520432E-102   ,
1.04795649947931E-102   ,
6.45094630358005E-103   ,
3.97092542543534E-103   ,
2.44426456386703E-103   ,
1.50450249405262E-103   ,
9.26031746736387E-104   ,
5.69963632307205E-104   ,
3.50797721879415E-104   ,
2.15901060068450E-104   ,
1.32874370160890E-104   ,
8.17741689294717E-105   ,
5.03245125597876E-105   ,
3.09693132134015E-105   ,
1.90577740040442E-105   ,
1.17273912068644E-105   ,
7.21637903101456E-106   ,
4.44043976011263E-106   ,
2.73225603393637E-106   ,
1.68114668766460E-106   ,
1.03437655740773E-106   ,
6.36415302870726E-107   ,
3.91553835529557E-107   ,
2.40896957362443E-107   ,
1.48204076542588E-107   ,
9.11754732792064E-108   ,
5.60899410635556E-108   ,
3.45049228107581E-108   ,
2.12259088221367E-108   ,
1.30569194320215E-108   ,
8.03164284963684E-109   ,
4.94034551520429E-109   ,
3.03878215949517E-109   ,
1.86909406828808E-109   ,
1.14961423888997E-109   ,
7.07070193702461E-110   ,
4.34872939102460E-110   ,
2.67455622037114E-110   ,
1.64486632659586E-110   ,
1.01157725397673E-110   ,
6.22095563065313E-111   ,
3.82564609201225E-111   ,
2.35256782585169E-111   ,
1.44666916667215E-111   ,
8.89582114844381E-112   ,
5.47006693703243E-112   ,
3.36348158564185E-112   ,
2.06811801734756E-112   ,
1.27160277473205E-112   ,
7.81839368444293E-113   ,
4.80699373994576E-113   ,
2.95542243516132E-113   ,
1.81700280021969E-113   ,
1.11707332866869E-113   ,
6.86748718374340E-114   ,
4.22186317946409E-114   ,
2.59537793053821E-114   ,
1.59546487881354E-114   ,
9.80763084783710E-115   ,
6.02880486963713E-115   ,
3.70585677751667E-115   ,
2.27790890949288E-115   ,
1.40014955569213E-115   ,
8.60603056126479E-116   ,
5.28958690031854E-116   ,
3.25110559722339E-116   ,
1.99816282051296E-116   ,
1.22806451347117E-116   ,
7.54748105550053E-117   ,
4.63845613244018E-117   ,
2.85059473874994E-117   ,
1.75181459033095E-117   ,
1.07654320481226E-117   ,
6.61554281389693E-118   ,
4.06527782183474E-118   ,
2.49807649563028E-118   ,
1.53501287233644E-118   ,
9.43211585319534E-119   ,
5.79558229681969E-119   ,
3.56103222183028E-119   ,
2.18799152101864E-119   ,
1.34433126893690E-119   ,
8.25957934791722E-120   ,
5.07458523760265E-120   ,
3.11769908415697E-120   ,
1.91539738201229E-120   ,
1.17672413930766E-120   ,
7.22905524097788E-121   ,
4.44098759624392E-121   ,
2.72815311581481E-121   ,
1.67590391107060E-121   ,
1.02948662366563E-121   ,
6.32387897491121E-122   ,
3.88452273471574E-122   ,
2.38606949606051E-122   ,
1.46561479582207E-122   ,
9.00218535685269E-123   ,
5.52926553169522E-123   ,
3.39608346006061E-123   ,
2.08583860978680E-123   ,
1.28107488152879E-123   ,
7.86791795526126E-124   ,
4.83210818061611E-124   ,
2.96759766465210E-124   ,
1.82248920608698E-124   ,
1.11922269360304E-124   ,
6.87321096821802E-125   ,
4.22079725979151E-125   ,
2.59191637586887E-125   ,
1.59161924295208E-125   ,
9.77347720385861E-126   ,
6.00137521622950E-126   ,
3.68505721249831E-126   ,
2.26271310895390E-126   ,
1.38933373026437E-126   ,
8.53052028556388E-127   ,
5.23764837464454E-127   ,
3.21580022605338E-127   ,
1.97439349624523E-127   ,
1.21218893303300E-127   ,
7.44215814738068E-128   ,
4.56898230279600E-128   ,
2.80499494346011E-128   ,
1.72201424263672E-128   ,
1.05714234481568E-128   ,
6.48966526909764E-129   ,
3.98385245675031E-129   ,
2.44554883556851E-129   ,
1.50121053062564E-129   ,
9.21507887219506E-130   ,
5.65651217943570E-130   ,
3.47208729022958E-130   ,
2.13120293357255E-130   ,
1.30813106830261E-130   ,
8.02915835073348E-131   ,
4.92811820871523E-131   ,
3.02471571853470E-131   ,
1.85643772791754E-131   ,
1.13938003991417E-131   ,
6.99277008208647E-132   ,
4.29163061266248E-132   ,
2.63383088103327E-132   ,
1.61638913988029E-132   ,
9.91965281077557E-133   ,
6.08750809695049E-133   ,
3.73572746360103E-133   ,
2.29246858878517E-133   ,
1.40677356613568E-133   ,
8.63252059290755E-134   ,
5.29716726838642E-134   ,
3.25044193227253E-134   ,
1.99449898514355E-134   ,
1.22382108453100E-134   ,
7.50921895076658E-135   ,
4.60748945279959E-135   ,
2.82700579516702E-135   ,
1.73453007880248E-135   ,
1.06421599114739E-135   ,
6.52935909994109E-136   ,
4.00593758164894E-136   ,
2.45771019890990E-136   ,
1.50782193098646E-136   ,
9.25043914672884E-137   ,
5.67502234939488E-137   ,
3.48149481680942E-137   ,
2.13578189536445E-137   ,
1.31021039158416E-137   ,
8.03744824360803E-138   ,
4.93047055779541E-138   ,
3.02448615331139E-138   ,
1.85527332922689E-138   ,
1.13803938338894E-138   ,
6.98071312613948E-139   ,
4.28188913553324E-139   ,
2.62642010261996E-139   ,
1.61096511465503E-139   ,
9.88100829621274E-140   ,
6.06051592798823E-140   ,
3.71715913423933E-140   ,
2.27984831872996E-140   ,
1.39827957955678E-140   ,
8.57581408011512E-141   ,
5.25956707516027E-141   ,
3.22565530425365E-141   ,
1.97824123928691E-141   ,
1.21320418628447E-141   ,
7.44015395367883E-142   ,
4.56271492533172E-142   ,
2.79806731019955E-142   ,
1.71587800582472E-142   ,
1.05222375636736E-142   ,
6.45242940203031E-143   ,
3.95668887207191E-143   ,
2.42624157739113E-143   ,
1.48774910223240E-143   ,
9.12260535295687E-144   ,
5.59373168107250E-144   ,
3.42987223779143E-144   ,
2.10304149908762E-144   ,
1.28947030983448E-144   ,
7.90621231972244E-145   ,
4.84751585589460E-145   ,
2.97210165700622E-145   ,
1.82222396840272E-145   ,
1.11720672215719E-145   ,
6.84950256974485E-146   ,
4.19931303501752E-146   ,
2.57448999423897E-146   ,
1.57833041071125E-146   ,
9.67605693617730E-147   ,
5.93188464907996E-147   ,
3.63647651350238E-147   ,
2.22927015127434E-147   ,
1.36659068435430E-147   ,
8.37737715083839E-148   ,
5.13536779536052E-148   ,
3.14795799181009E-148   ,
1.92965739910193E-148   ,
1.18283839093480E-148   ,
7.25044316498217E-149   ,
4.44424146667033E-149   ,
2.72411044709433E-149   ,
1.66972812315710E-149   ,
1.02343629302670E-149   ,
6.27292193502979E-150   ,
3.84479319560426E-150   ,
2.35651460300073E-150   ,
1.44431309871674E-150   ,
8.85210678143919E-151   ,
5.42532842119890E-151   ,
3.32506035436351E-151   ,
2.03782627653179E-151   ,
1.24890361867901E-151   ,
7.65393634666677E-152   ,
4.69067063893398E-152   ,
2.87461190060132E-152   ,
1.76164217935333E-152   ,
1.07956898048927E-152   ,
6.61572319369269E-153   ,
4.05413774258069E-153   ,
2.48435660813573E-153   ,
1.52238201912429E-153   ,
9.32884004545605E-154   ,
5.71644398406031E-154   ,
3.50282609988657E-154   ,
2.14637467611558E-154   ,
1.31518498680670E-154   ,
8.05865404785401E-155   ,
4.93778935179419E-155   ,
3.02549888099960E-155   ,
1.85376995893540E-155   ,
1.13581893110937E-155   ,
6.95915964931641E-156   ,
4.26382080439675E-156   ,
2.61237519109547E-156   ,
1.60054037105490E-156   ,
9.80600713598496E-157   ,
6.00775592561342E-157   ,
3.68066993176108E-157   ,
2.25494522736694E-157   ,
1.38146429941375E-157   ,
8.46326409811947E-158   ,
5.18478429114696E-158   ,
3.17627486207496E-158   ,
1.94580834408840E-158   ,
1.19200110464884E-158   ,
7.30210174953290E-159   ,
4.47315288454409E-159   ,
2.74014948638832E-159   ,
1.67853126868205E-159   ,
1.02820401377919E-159   ,
6.29830729274339E-160   ,
3.85800780753314E-160   ,
2.36318149238365E-160   ,
1.44752403155042E-160   ,
8.86643904175562E-161   ,
5.43084539772575E-161   ,
3.32644553385794E-161   ,
2.03745570949595E-161   ,
1.24793145692971E-161   ,
7.64342653954866E-162   ,
4.68144882872757E-162   ,
2.86726147076246E-162   ,
1.75609967778373E-162   ,
1.07553831480468E-162   ,
6.58714889690216E-163   ,
4.03426068724041E-163   ,
2.47073024681558E-163   ,
1.51314871719224E-163   ,
9.26686458318117E-164   ,
5.67517100565188E-164   ,
3.47552192899004E-164   ,
2.12841382437278E-164   ,
1.30342809694639E-164   ,
7.98202470116246E-165   ,
4.88803210668301E-165   ,
2.99329856769805E-165   ,
1.83299399989494E-165   ,
1.12245019112922E-165   ,
6.87334517390378E-166   ,
4.20885809704709E-166   ,
2.57724364698680E-166   ,
1.57812626704785E-166   ,
9.66324760002600E-167   ,
5.91697271464596E-167   ,
3.62302338503674E-167   ,
2.21838965346943E-167   ,
1.35831238177222E-167   ,
8.31680720883543E-168   ,
5.09223885828180E-168   ,
3.11785610683859E-168   ,
1.90896756720250E-168   ,
1.16878929052717E-168   ,
7.15597970593219E-169   ,
4.38124148513275E-169   ,
2.68238126926425E-169   ,
1.64224920781794E-169   ,
1.00543236733253E-169   ,
6.15547996541635E-170   ,
3.76848032437895E-170   ,
2.30709704597528E-170   ,
1.41240994258778E-170   ,
8.64671156260744E-171   ,
5.29342167970201E-171   ,
3.24053962377332E-171   ,
1.98378003939652E-171   ,
1.21440918247363E-171   ,
7.43416037391668E-172   ,
4.55086735066278E-172   ,
2.78581201013839E-172   ,
1.70531583596493E-172   ,
1.04388640930735E-172   ,
6.38994429311614E-173   ,
3.91143683657545E-173   ,
2.39425830324014E-173   ,
1.46555163637241E-173   ,
8.97070756505495E-174   ,
5.49095312996143E-174   ,
3.36096698833100E-174   ,
2.05719869536706E-174   ,
1.25916814205128E-174   ,
7.70702411464980E-175   ,
4.71721013045935E-175   ,
2.88721583778509E-175   ,
1.76713128045474E-175   ,
1.08156823059172E-175   ,
6.61964323894746E-176   ,
4.05145305126456E-176   ,
2.47960561816134E-176   ,
1.51757441897427E-176   ,
9.28780261662802E-177   ,
5.68422894244181E-177   ,
3.47877035218826E-177   ,
2.12899961424391E-177   ,
1.30292986609381E-177   ,
7.97374126295803E-178   ,
4.87976483161097E-178   ,
2.98628538808103E-178   ,
1.82750847027596E-178   ,
1.11836397799507E-178   ,
6.84388390497752E-179   ,
4.18810729269067E-179   ,
2.56288238092431E-179   ,
1.56832213639380E-179   ,
9.59704651052075E-180   ,
5.87267093018876E-180   ,
3.59359790911983E-180   ,
2.19896874181281E-180   ,
1.34556411920778E-180   ,
8.23351946494004E-181   ,
5.03804940171461E-181   ,
3.08272740015010E-181   ,
1.88626900381691E-181   ,
1.15416512693296E-181   ,
7.06200614193804E-182   ,
4.32099800980940E-182   ,
2.64384434752597E-182   ,
1.61764623217289E-182   ,
9.89753571465262E-183   ,
6.05572957767581E-183   ,
3.70511546359100E-183   ,
2.26690283978144E-183   ,
1.38694730819202E-183   ,
8.48560715359206E-184   ,
5.19160683167902E-184   ,
3.17626398847681E-184   ,
1.94324391837639E-184   ,
1.18886894686660E-184   ,
7.27338536418565E-185   ,
4.44974547860965E-185   ,
2.72226066913805E-185   ,
1.66540636977368E-185   ,
1.01884171343585E-185   ,
6.23288631537272E-186   ,
3.81300780560817E-186   ,
2.33261031671782E-186   ,
1.42696298419144E-186   ,
8.72929658311043E-187   ,
5.34000698903292E-187   ,
3.26663375045903E-187   ,
1.99827435919388E-187   ,
1.22237890539355E-187   ,
7.47743499010808E-188   ,
4.57399327576464E-188   ,
2.79791478187617E-188   ,
1.71147096974326E-188   ,
1.04688913549170E-188   ,
6.40365547681956E-189   ,
3.91697989179196E-189   ,
2.39591194072126E-189   ,
1.46550227267387E-189   ,
8.96392642273083E-190   ,
5.48284818244690E-190   ,
3.35359270994896E-190   ,
2.05121214840372E-190   ,
1.25460501127781E-190   ,
7.67360850999581E-191   ,
4.69340952500716E-191   ,
2.87060515791587E-191   ,
1.75571766229607E-191   ,
1.07382153681443E-191   ,
6.56758594099591E-192   ,
4.01675783449410E-192   ,
2.45664143501696E-192   ,
1.50246423200361E-192   ,
9.18888391510882E-193   ,
5.61975846069979E-193   ,
3.43691509885616E-193   ,
2.10192025524582E-193   ,
1.28546409727041E-193   ,
7.86140118679436E-194   ,
4.80768791967755E-194   ,
2.94014592015010E-194   ,
1.79803365670573E-194   ,
1.09957047918308E-194   ,
6.72426246553059E-195   ,
4.11208970246441E-195   ,
2.51464595868554E-195   ,
1.53775614200322E-195   ,
9.40360660799015E-196   ,
5.75039665158384E-196   ,
3.51639398026016E-196   ,
2.15027316968882E-196   ,
1.31488004407227E-196   ,
8.04035139821460E-197   ,
4.91654852673481E-197   ,
3.00636732369034E-197   ,
1.83831602956763E-197   ,
1.12407355948994E-197   ,
6.87330671878830E-198   ,
4.20274613807400E-198   ,
2.56978647563930E-198   ,
1.57129372444101E-198   ,
9.60758367121848E-199   ,
5.87445314823755E-199   ,
3.59184171768956E-199   ,
2.19615718236203E-199   ,
1.34278394723578E-199   ,
8.21004163133314E-200   ,
5.01973837914574E-200   ,
3.06911610850014E-200   ,
1.87647193458984E-200   ,
1.14727453447554E-200   ,
7.01437802102288E-201   ,
4.28852079739932E-201   ,
2.62193801575389E-201   ,
1.60300129786186E-201   ,
9.80035681404374E-202   ,
5.99165045215927E-202   ,
3.66309029628272E-202   ,
2.23947057432558E-202   ,
1.36911422918774E-202   ,
8.37009914316578E-203   ,
5.11703186497234E-203   ,
3.12825572829767E-203   ,
1.91241873708429E-203   ,
1.16912339963757E-203   ,
7.14717380666764E-204   ,
4.36923062061754E-204   ,
2.67098983274495E-204   ,
1.63281186959139E-204   ,
9.98152082016163E-205   ,
6.10174348364218E-205   ,
3.72999150245026E-205   ,
2.28012372075921E-205   ,
1.39381669888352E-205   ,
8.52019630268034E-206   ,
5.20823092268260E-206   ,
3.18366646158841E-206   ,
1.94608407676275E-206   ,
1.18957642453486E-206   ,
7.27142982141631E-207   ,
4.44471594110745E-207   ,
2.71684546395408E-207   ,
1.66066716808859E-207   ,
1.01507237200182E-207   ,
6.20451967163968E-208   ,
3.79241696942042E-208   ,
2.31803911310308E-208   ,
1.41684456188126E-208   ,
8.66005063136757E-209   ,
5.29316505319638E-209   ,
3.23524541128769E-209   ,
1.97740586280770E-209   ,
1.20859614692168E-209   ,
7.38692006905773E-210   ,
4.51484044244386E-210   ,
2.75942269768399E-210   ,
1.68651761910861E-210   ,
1.03076666216181E-210   ,
6.29979883609310E-211   ,
3.85025809666292E-211   ,
2.35315130455804E-211   ,
1.43815838384517E-211   ,
8.78942456083815E-212   ,
5.37169115999700E-212   ,
3.28290639987952E-212   ,
2.00633220547457E-212   ,
1.22615132832392E-212   ,
7.49345652406646E-213   ,
4.57949097309511E-213   ,
2.79865345409605E-213   ,
1.71032226936260E-213   ,
1.04521032224273E-213   ,
6.38743287656623E-214   ,
3.90342585167647E-214   ,
2.38540678414249E-214   ,
1.45772601066119E-214   ,
8.90812492694266E-215   ,
5.44369322925100E-215   ,
3.32657976742631E-215   ,
2.03282128870841E-215   ,
1.24221687380101E-215   ,
7.59088862675881E-216   ,
4.63857722911564E-216   ,
2.83448358597057E-216   ,
1.73204866152883E-216   ,
1.05838390259737E-216   ,
6.46730528163656E-217   ,
3.95185046297734E-217   ,
2.41476378471676E-217   ,
1.47552244847786E-217   ,
9.01600222068382E-218   ,
5.50908186233603E-218   ,
3.36621208001673E-218   ,
2.05684118841370E-218   ,
1.25677371873330E-218   ,
7.67910257837518E-219   ,
4.69203131545171E-219   ,
2.86687260582485E-219   ,
1.75167266459055E-219   ,
1.07027302874507E-219   ,
6.53933047389852E-220   ,
3.99548101338174E-220   ,
2.44119203053201E-220   ,
1.49152970706832E-220   ,
9.11294961668643E-221   ,
5.56779367346979E-221   ,
3.40176575641170E-221   ,
2.07836964112244E-221   ,
1.26980868553254E-221   ,
7.75802045380809E-222   ,
4.73980719669183E-222   ,
2.89579334600729E-222   ,
1.76917826354163E-222   ,
1.08086827130183E-222   ,
6.60345300567316E-223   ,
4.03428494279918E-223   ,
2.46467242993493E-223   ,
1.50573660995520E-223   ,
9.19890180024294E-224   ,
5.61979056528609E-224   ,
3.43321862073056E-224   ,
2.09739376784913E-224   ,
1.28131431320273E-224   ,
7.82759914984559E-225   ,
4.78188004817070E-225   ,
2.92123155843018E-225   ,
1.78455731253139E-225   ,
1.09016499376525E-225   ,
6.65964662059787E-226   ,
4.06824746979721E-226   ,
2.48519671888458E-226   ,
1.51813857474933E-226   ,
9.27383361400866E-227   ,
5.66505889521072E-227   ,
3.46056338902835E-227   ,
2.11390975792535E-227   ,
1.29128866267373E-227   ,
7.88782918677116E-228   ,
4.81824551831753E-228   ,
2.94318546058443E-228   ,
1.79780925549934E-228   ,
1.09816318062769E-228   ,
6.70791319618432E-229   ,
4.09737094115147E-229   ,
2.50276706089829E-229   ,
1.52873736713054E-229   ,
9.33775854525663E-230   ,
5.70360854540119E-230   ,
3.48380709754507E-230   ,
2.12792251755875E-230   ,
1.29973510080419E-230   ,
7.93873338097726E-231   ,
4.84891891301506E-231   ,
2.96166523440781E-231   ,
1.80894081830914E-231   ,
1.10486724826095E-231   ,
6.74828158223469E-232   ,
4.12167411845375E-232   ,
2.51739560896128E-232   ,
1.53754083184531E-232   ,
9.39072707425769E-233   ,
5.73547190878394E-233   ,
3.50297048027163E-233   ,
2.13944528777778E-233   ,
1.30666206589347E-233   ,
7.98036540591223E-234   ,
4.87393431252884E-234   ,
2.97669248443401E-234   ,
1.81796567630009E-234   ,
1.11028584096053E-234   ,
6.78080634969946E-235   ,
4.14119141066516E-235   ,
2.52910403481685E-235   ,
1.54456260401994E-235   ,
9.43282490390911E-236   ,
5.76070280344967E-236   ,
3.51808730329798E-236   ,
2.14849923631082E-236   ,
1.31208281747435E-236   ,
8.01280825824198E-237   ,
4.89334363128804E-237   ,
2.98829966149456E-237   ,
1.82490410107375E-237   ,
1.11443161447682E-237   ,
6.80556646410787E-238   ,
4.15597206122803E-238   ,
2.53792303087955E-238   ,
1.54982180398500E-238   ,
9.46417109004489E-239   ,
5.77937532725045E-239   ,
3.52920366316398E-239   ,
2.15511302779405E-239   ,
1.31601517306271E-239   ,
8.03617264552239E-240   ,
4.90721563044351E-240   ,
2.99652945801237E-240   ,
1.82978259019339E-240   ,
1.11732100927018E-240   ,
6.82266389723482E-241   ,
4.16607929804846E-241   ,
2.54389178983313E-241   ,
1.55334271869026E-241   ,
9.48491609120543E-242   ,
5.79158266401052E-242   ,
3.53637725614735E-242   ,
2.15932237653427E-242   ,
1.31848123443658E-242   ,
8.05059531103528E-243   ,
4.91563489272576E-243   ,
3.00143418068127E-243   ,
1.83263348332813E-243   ,
1.11897401563891E-243   ,
6.83222219005226E-244   ,
4.17158945428796E-244   ,
2.54705746674831E-244   ,
1.55515447265200E-244   ,
9.49523975572843E-245   ,
5.79743585224152E-245   ,
3.53967662512833E-245   ,
2.16116958585921E-245   ,
1.31950710589629E-245   ,
8.05623731071271E-246   ,
4.91870076868250E-246   ,
3.00307510606105E-246   ,
1.83349456819282E-246   ,
1.11941393276167E-246   ,
6.83438497938678E-247   ,
4.17259106753046E-247   ,
2.54747462831089E-247   ,
1.55529069122722E-247   ,
9.49534926318614E-248   ,
5.79706252669314E-248   ,
3.53918039030214E-248   ,
2.16070307787439E-248   ,
1.31912260682918E-248   ,
8.05328225626482E-249   ,
4.91652630288477E-249   ,
3.00152182429699E-249   ,
1.83240867946433E-249   ,
1.11866712358375E-249   ,
6.82931450002715E-250   ,
4.16918396444445E-250   ,
2.54520469350123E-250   ,
1.55378915884845E-250   ,
9.48547703616675E-251   ,
5.79060564247772E-251   ,
3.53497646966281E-251   ,
2.15797691722151E-251   ,
1.31736098076449E-251   ,
8.04193453779867E-252   ,
4.90923714816232E-252   ,
2.99685157587851E-252   ,
1.82942329365073E-252   ,
1.11676276735826E-252   ,
6.81719007326581E-253   ,
4.16147833763537E-253   ,
2.54031536978061E-253   ,
1.55069147468879E-253   ,
9.46587863739450E-254   ,
5.77822219087207E-254   ,
3.52716129478771E-254   ,
2.15305033220344E-254   ,
1.31425860296028E-254   ,
8.02241753832845E-255   ,
4.89697047541387E-255   ,
2.98914858600761E-255   ,
1.82459012269335E-255   ,
1.11373261153065E-255   ,
6.79820659214232E-256   ,
4.14959382090555E-256   ,
2.53288008857225E-256   ,
1.54604270805189E-256   ,
9.43683066613604E-257   ,
5.76008191526307E-257   ,
3.51583902706498E-257   ,
2.14598723639136E-257   ,
1.30985468841495E-257   ,
7.99497185168302E-258   ,
4.87987388596728E-258   ,
2.97850340081648E-258   ,
1.81796470887530E-258   ,
1.10961072452726E-258   ,
6.77257301285745E-259   ,
4.13365856868053E-259   ,
2.52297744352012E-259   ,
1.53989105560542E-259   ,
9.39862866674287E-260   ,
5.73636603504757E-260   ,
3.50112077910060E-260   ,
2.13685575359156E-260   ,
1.30419100205081E-260   ,
7.95985351437751E-261   ,
4.85810433291133E-261   ,
2.96501222932860E-261   ,
1.80960602339912E-261   ,
1.10443325088292E-261   ,
6.74051086106216E-262   ,
4.11380834487987E-262   ,
2.51069063473479E-262   ,
1.53228750240129E-262   ,
9.35158506112559E-263   ,
5.70726598461731E-263   ,
3.48312384563403E-263   ,
2.12572774879977E-263   ,
1.29731157266051E-263   ,
7.91733226113944E-264   ,
4.83182705726408E-264   ,
2.94877629472114E-264   ,
1.79957607078860E-264   ,
1.09823817001354E-264   ,
6.70225276094018E-265   ,
4.09018562602713E-265   ,
2.49610692193382E-265   ,
1.52328548844782E-265   ,
9.29602711583632E-266   ,
5.67298217393074E-266   ,
3.46197094789604E-266   ,
2.11267836752166E-266   ,
1.28926241206099E-266   ,
7.86768981280955E-267   ,
4.80121454426962E-267   ,
2.92990119809833E-267   ,
1.78793950106136E-267   ,
1.09106505981240E-267   ,
6.65804099423198E-268   ,
4.06293872293595E-268   ,
2.47931708909778E-268   ,
1.51294058241907E-268   ,
9.23229495340086E-269   ,
5.63372277648243E-269   ,
3.43778949494108E-269   ,
2.09778558560272E-269   ,
1.28009124075052E-269   ,
7.81121820448414E-270   ,
4.76644550458560E-270   ,
2.90849629764873E-270   ,
1.77476323141407E-270   ,
1.08295486612641E-270   ,
6.60812609557985E-271   ,
4.03222092483618E-271   ,
2.46041492298665E-271   ,
1.50131016392258E-271   ,
9.16073961646103E-272   ,
5.58970254987799E-272   ,
3.41071086508827E-272   ,
2.08112977146437E-272   ,
1.26984722121782E-272   ,
7.74821816084522E-273   ,
4.72770388456487E-273   ,
2.88467410574295E-273   ,
1.76011607896151E-273   ,
1.07394967904360E-273   ,
6.55276548984372E-274   ,
3.99818966934610E-274   ,
2.43949670757510E-274   ,
1.48845311557066E-274   ,
9.08172119229548E-275   ,
5.54114169356217E-275   ,
3.38086971024064E-275   ,
2.06279326241779E-275   ,
1.25858069991411E-275   ,
7.67899752478375E-276   ,
4.68517790931701E-276   ,
2.85854970619291E-276   ,
1.74406840587640E-276   ,
1.06409251680528E-276   ,
6.49222217629931E-277   ,
3.96100574127480E-277   ,
2.41666073620740E-277   ,
1.47442952594093E-277   ,
8.99560700424441E-278   ,
5.48826474767681E-278   ,
3.34840328546606E-278   ,
2.04285995649850E-278   ,
1.24634295875921E-278   ,
7.60386974458808E-279   ,
4.63905916174119E-279   ,
2.83024019359757E-279   ,
1.72669177809171E-279   ,
1.05342711804634E-279   ,
6.42676346395125E-280   ,
3.92083250279380E-280   ,
2.39200684300922E-280   ,
1.45930040435649E-280   ,
8.90276987567709E-281   ,
5.43129953641581E-281   ,
3.31345080588581E-281   ,
2.02141492105489E-281   ,
1.23318597692371E-281   ,
7.52315242415995E-282   ,
4.58954170021773E-282   ,
2.79986413640025E-282   ,
1.70805863854165E-282   ,
1.04199774294973E-282   ,
6.35665976151470E-283   ,
3.87783515713224E-283   ,
2.36563595484726E-283   ,
1.44312740826234E-283   ,
8.80358647117161E-284   ,
5.37047615871082E-284   ,
3.27615283256994E-284   ,
1.99854401910936E-284   ,
1.21916220350546E-284   ,
7.43716593998753E-285   ,
4.53682121719932E-285   ,
2.76754106500286E-285   ,
1.68824199575560E-285   ,
1.02984898380604E-285   ,
6.28218342500583E-286   ,
3.83218004755120E-286   ,
2.33764966490170E-286   ,
1.42597258383669E-286   ,
8.69843571872939E-287   ,
5.30602602854633E-287   ,
3.23665068881752E-287   ,
1.97433355433034E-287   ,
1.20432434159603E-287   ,
7.34623212785913E-288   ,
4.48109424049383E-288   ,
2.73339098601505E-288   ,
1.66731512844824E-288   ,
1.01702558536418E-288   ,
6.20360766525151E-289   ,
3.78403399299804E-289   ,
2.30814982867927E-289   ,
1.40789812033662E-289   ,
8.58769731605775E-290   ,
5.23818096670213E-290   ,
3.19508590790908E-290   ,
1.94886993525243E-290   ,
1.18872514412774E-290   ,
7.25067304162298E-291   ,
4.42255737862837E-291   ,
2.69753392346745E-291   ,
1.64535130660235E-291   ,
1.00357227527030E-291   ,
6.12120551710710E-292   ,
3.73356366149141E-292   ,
2.27723818310851E-292   ,
1.38896611855723E-292   ,
8.47175032313163E-293   ,
5.16717234526220E-293   ,
3.15159971311949E-293   ,
1.92223935922661E-293   ,
1.17241722178018E-293   ,
7.15080978570044E-294   ,
4.36140661129409E-294   ,
2.66008948757980E-294   ,
1.62242352939813E-294   ,
9.89533604802784E-295   ,
6.03524887160802E-295   ,
3.68093498197894E-295   ,
2.24501598914155E-295   ,
1.36923837366011E-295   ,
8.35097184258576E-296   ,
5.09323028579492E-296   ,
3.10633253052964E-296   ,
1.89452751640955E-296   ,
1.15545286313243E-296   ,
7.04696142240717E-297   ,
4.29783662550185E-297   ,
2.62117647146377E-297   ,
1.59860428020643E-297   ,
9.74953800034066E-298   ,
5.94600757181344E-298   ,
3.62631259509984E-298   ,
2.21158369812835E-298   ,
1.34877617251862E-298   ,
8.22573578878163E-299   ,
5.01658291169775E-299   ,
3.05942353491903E-299   ,
1.86581931396034E-299   ,
1.13788386715752E-299   ,
6.93944395465336E-300   ,
4.23204019777015E-300   ,
2.58091247593303E-300   ,
1.57396529874651E-300   ,
9.59876623472121E-301   ,
5.85374857264485E-301   ,
3.56985934302606E-301   ,
2.17704064204598E-301   ,
1.32764010563271E-301   ,
8.09641174580986E-302   ,
4.93745565483508E-302   ,
3.01101022880781E-302   ,
1.83619862047041E-302   ,
1.11976138806744E-302   ,
6.82856938404231E-303   ,
4.16420762233959E-303   ,
2.53941356240524E-303   ,
1.54857737039279E-303   ,
9.44345246169594E-304   ,
5.75873516461671E-304   ,
3.51173579829309E-304   ,
2.14148474752553E-304   ,
1.30588989356368E-304   ,
7.96336391412196E-305   ,
4.85607061626563E-305   ,
2.96122805450230E-305   ,
1.80574803053578E-305   ,
1.10113579244900E-305   ,
6.71464484395574E-306   ,
4.09452618514045E-306   ,
2.49679393372534E-306   ,
1.52251013251365E-306   ,
9.28402130224960E-307   ,
5.66122626095566E-307   ,
3.45209983130663E-307   ,
2.10501227347534E-307   ,
1.28358422776517E-307   ,
7.82695014497467E-308   ,
4.77264598053165E-308   ,
2.91021003881535E-308
             #endregion	
        };
    }
}
