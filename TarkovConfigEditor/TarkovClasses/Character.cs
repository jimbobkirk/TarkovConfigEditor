using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarkovConfigEditor.TarkovClasses
{
    public class Character
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

        public override string ToString()
        {
            return Info.Nickname;
        }
        public string _id { get; set; }
        public string aid { get; set; }
        public string savage { get; set; }
        public _Info Info { get; set; }
        public object Customization { get; set; }
        public object Health { get; set; }
        public object Inventory { get; set; }
        public _Skills Skills { get; set; }
        public object Stats { get; set; }
        public object Encyclopedia { get; set; }
        public object ConditionCounters { get; set; }
        public object BackendCounters { get; set; }
        public List<object> InsuredItems { get; set; }
        public object Hideout { get; set; }
        public List<object> Bonuses { get; set; }
        public object Notes { get; set; }
        public List<Quest> Quests { get; set; }
        public object TradersInfo { get; set; }
        public object RagfairInfo { get; set; }
        public List<object> WishList { get; set; }

        public class _54cb50c76803fa8b248b4571
        {
            public int salesSum { get; set; }
            public double standing { get; set; }
            public bool unlocked { get; set; }
        }

        public class _54cb57776803fa99248b456e
        {
            public int salesSum { get; set; }
            public double standing { get; set; }
            public bool unlocked { get; set; }
        }

        public class _579dc571d53a0658a154fbec
        {
            public int salesSum { get; set; }
            public int standing { get; set; }
            public bool unlocked { get; set; }
        }

        public class _58330581ace78e27b8b10cee
        {
            public int salesSum { get; set; }
            public double standing { get; set; }
            public bool unlocked { get; set; }
        }

        public class _5935c25fb3acc3127c3d8cd9
        {
            public int salesSum { get; set; }
            public double standing { get; set; }
            public bool unlocked { get; set; }
        }

        public class _596737cb86f77463a8115efd
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _59675e1d86f77414b07f137d
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5967920f86f77468d219d632
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5968948986f7740d121082d4
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5968975586f7740e7266d974
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5968988286f7740d14064724
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _59689eb886f7740d137ebfc3
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _59689f7586f7740d14064726
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5969f99286f77456630ea442
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5969fa8986f7741ddc2d3154
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _596a0e8086f7741ddd6c104c
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _596a10d886f7741ddf11dbf0
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _596a1f1586f77420d2328077
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _596a20ac86f7741ddf17dbf4
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _596b450986f7745a7e510b54
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _596b470c86f77457ca18618a
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _596b472686f77457c7006f8a
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _597867e986f7741b265c6bd3
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5979ee4586f7743ec214c7a5
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5979fc7e86f77426d702a0f4
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5979fc9286f77426d702a0f5
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _597a0bdb86f7742717106d12
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _597a0bf886f7742717106d13
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _597a15c386f77405ba6887d2
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _59c50f1686f77412ef2c01e7
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5a27d34586f7744e1115b327
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5a27ffc786f77415ca58ae47
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5a28023f86f774528903dd1e
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5a294f3386f77433e923f9cd
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5a56489d86f7740cfe70eba2
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5a68763786f77474c33a40a1
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5a68777586f774747d4b0d9e
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5a7c2eca46aef81a7ca2145d
        {
            public int salesSum { get; set; }
            public double standing { get; set; }
            public bool unlocked { get; set; }
        }

        public class _5ab8d44c86f7745b2325bd0c
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ac3b934156ae10c4430e83c
        {
            public int salesSum { get; set; }
            public double standing { get; set; }
            public bool unlocked { get; set; }
        }

        public class _5ac5055a86f7745cae22b582
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ac505e186f7740bdf2ceabe
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ac5062586f774587c327395
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ac5082586f77418804f7d4c
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ac5084d86f7740bde1b0031
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ac5e79986f7747398341847
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ac5e88e86f7741c5804f9db
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ac5e98886f77479bc6ca201
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ac5ea0586f774609f36280c
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ac5eee986f77401fd341c9e
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ac5ef5686f77416ca60f644
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ac5eff886f7740f43322559
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ac624b286f77416781dd3ac
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5accd5e386f77463027e9397
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5accd9b686f774112d7173d1
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5accde3686f7740cea1b7ec2
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5accdfdb86f77412265cbfc9
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5acce08b86f7745f8521fa64
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5acce11786f77411ed6fa6eb
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ae34b8b86f7741e5b1e5d48
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ae4543686f7742dc043c903
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ae454a086f7742be909a81a
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ae455be86f7742dc043c969
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ae4562086f774498b05e0dc
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ae9b34686f7743129512ccf
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ae9b38a86f77432c81e2ce3
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ae9b3c986f77432c81e2ce6
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ae9b63286f774229110402d
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5b47886986f7744d1a393e65
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5b4c769686f7746e535a5c0e
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5c0647fdd443bc2504c2d371
        {
            public int salesSum { get; set; }
            public double standing { get; set; }
            public bool unlocked { get; set; }
        }

        public class _5c0be66c86f7744523489ab2
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5c0be69086f7743c9c1ecf43
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5c1129ed86f7746569440e88
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5c112a1b86f774656777d1ae
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5c139eb686f7747878361a72
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5c139eb686f7747878361a73
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5d249aa286f77475e8376399
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5d24ba7886f77439c92d6baa
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5d24bb4886f77439c92d6bad
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5d24bb7286f7741f7956be74
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5d27491686f77475aa5cf5b9
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5d4bfe7c86f7744a9c66b316
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5d4c028c86f774389001e027
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5d5c205bd582a50d042a3c0e
        {
            public int Progress { get; set; }
            public bool inProgress { get; set; }
            public string RecipeId { get; set; }
            public List<object> Products { get; set; }
            public int SkipTime { get; set; }
            public int ProductionTime { get; set; }
            public int StartTimestamp { get; set; }
        }

        public class _5d6fb8a886f77449db3db8b6
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5ec137dcc367fc6781104613
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5edabb950c502106f869bc04
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5edabc2ca0055865214cb5a6
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5edac1040880da21347b3845
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5edac1530880da21347b3846
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5edac1b2930f5454f51dcac4
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5edac1fccc183c769d778bd3
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5edac2582ddc9e4c802cd970
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5edac2a260bdcc7ff3558127
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5edac2e10bb72a50635c2bf9
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5f04935cde3b9e0ecf03d864
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5f04944b69ef785df740a8c9
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5f0495458654d20be3564f4c
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class _5f0495b8efefac7f7227de63
        {
            public string id { get; set; }
            public string qid { get; set; }
            public int value { get; set; }
        }

        public class Aggressor
        {
            public object AccountId { get; set; }
            public object ProfileId { get; set; }
            public string Name { get; set; }
            public string Side { get; set; }
            public string BodyPart { get; set; }
            public object HeadSegment { get; set; }
            public string WeaponName { get; set; }
            public string Category { get; set; }
        }

        public class Area
        {
            public int type { get; set; }
            public int level { get; set; }
            public bool active { get; set; }
            public bool passiveBonusesEnabled { get; set; }
            public int completeTime { get; set; }
            public bool constructing { get; set; }
            public List<Slot> slots { get; set; }
            public string lastRecipe { get; set; }
        }

        //public class BackendCounters
        //{
        //    public _59689eb886f7740d137ebfc3 _59689eb886f7740d137ebfc3 { get; set; }
        //    public _5d249aa286f77475e8376399 _5d249aa286f77475e8376399 { get; set; }
        //    public _5d24ba7886f77439c92d6baa _5d24ba7886f77439c92d6baa { get; set; }
        //    public _5d24bb4886f77439c92d6bad _5d24bb4886f77439c92d6bad { get; set; }
        //    public _5d24bb7286f7741f7956be74 _5d24bb7286f7741f7956be74 { get; set; }
        //    public _596737cb86f77463a8115efd _596737cb86f77463a8115efd { get; set; }
        //    public _59689f7586f7740d14064726 _59689f7586f7740d14064726 { get; set; }
        //    public _596a20ac86f7741ddf17dbf4 _596a20ac86f7741ddf17dbf4 { get; set; }
        //    public _5969f99286f77456630ea442 _5969f99286f77456630ea442 { get; set; }
        //    public _5967920f86f77468d219d632 _5967920f86f77468d219d632 { get; set; }
        //    public _5969fa8986f7741ddc2d3154 _5969fa8986f7741ddc2d3154 { get; set; }
        //    public _596b472686f77457c7006f8a _596b472686f77457c7006f8a { get; set; }
        //    public _596b470c86f77457ca18618a _596b470c86f77457ca18618a { get; set; }
        //    public _597867e986f7741b265c6bd3 _597867e986f7741b265c6bd3 { get; set; }
        //    public _5ab8d44c86f7745b2325bd0c _5ab8d44c86f7745b2325bd0c { get; set; }
        //    public _596a1f1586f77420d2328077 _596a1f1586f77420d2328077 { get; set; }
        //    public _596b450986f7745a7e510b54 _596b450986f7745a7e510b54 { get; set; }
        //    public _5979ee4586f7743ec214c7a5 _5979ee4586f7743ec214c7a5 { get; set; }
        //    public _5a56489d86f7740cfe70eba2 _5a56489d86f7740cfe70eba2 { get; set; }
        //    public _5d27491686f77475aa5cf5b9 _5d27491686f77475aa5cf5b9 { get; set; }
        //    public _5accd5e386f77463027e9397 _5accd5e386f77463027e9397 { get; set; }
        //    public _5accd9b686f774112d7173d1 _5accd9b686f774112d7173d1 { get; set; }
        //    public _5ec137dcc367fc6781104613 _5ec137dcc367fc6781104613 { get; set; }
        //    public _5979fc7e86f77426d702a0f4 _5979fc7e86f77426d702a0f4 { get; set; }
        //    public _5979fc9286f77426d702a0f5 _5979fc9286f77426d702a0f5 { get; set; }
        //    public _5accde3686f7740cea1b7ec2 _5accde3686f7740cea1b7ec2 { get; set; }
        //    public _5accdfdb86f77412265cbfc9 _5accdfdb86f77412265cbfc9 { get; set; }
        //    public _5acce08b86f7745f8521fa64 _5acce08b86f7745f8521fa64 { get; set; }
        //    public _597a0bf886f7742717106d13 _597a0bf886f7742717106d13 { get; set; }
        //    public _597a0bdb86f7742717106d12 _597a0bdb86f7742717106d12 { get; set; }
        //    public _5ac505e186f7740bdf2ceabe _5ac505e186f7740bdf2ceabe { get; set; }
        //    public _5ac5062586f774587c327395 _5ac5062586f774587c327395 { get; set; }
        //    public _5ac5055a86f7745cae22b582 _5ac5055a86f7745cae22b582 { get; set; }
        //    public _5ac5ef5686f77416ca60f644 _5ac5ef5686f77416ca60f644 { get; set; }
        //    public _5ac5eee986f77401fd341c9e _5ac5eee986f77401fd341c9e { get; set; }
        //    public _5ac5eff886f7740f43322559 _5ac5eff886f7740f43322559 { get; set; }
        //    public _597a15c386f77405ba6887d2 _597a15c386f77405ba6887d2 { get; set; }
        //    public _5a27d34586f7744e1115b327 _5a27d34586f7744e1115b327 { get; set; }
        //    public _596a10d886f7741ddf11dbf0 _596a10d886f7741ddf11dbf0 { get; set; }
        //    public _5968948986f7740d121082d4 _5968948986f7740d121082d4 { get; set; }
        //    public _59675e1d86f77414b07f137d _59675e1d86f77414b07f137d { get; set; }
        //    public _5ac624b286f77416781dd3ac _5ac624b286f77416781dd3ac { get; set; }
        //    public _5ac5084d86f7740bde1b0031 _5ac5084d86f7740bde1b0031 { get; set; }
        //    public _5ac5082586f77418804f7d4c _5ac5082586f77418804f7d4c { get; set; }
        //    public _5acce11786f77411ed6fa6eb _5acce11786f77411ed6fa6eb { get; set; }
        //    public _5ae34b8b86f7741e5b1e5d48 _5ae34b8b86f7741e5b1e5d48 { get; set; }
        //    public _5968975586f7740e7266d974 _5968975586f7740e7266d974 { get; set; }
        //    public _5c1129ed86f7746569440e88 _5c1129ed86f7746569440e88 { get; set; }
        //    public _5c112a1b86f774656777d1ae _5c112a1b86f774656777d1ae { get; set; }
        //    public _5968988286f7740d14064724 _5968988286f7740d14064724 { get; set; }
        //    public _5d4c028c86f774389001e027 _5d4c028c86f774389001e027 { get; set; }
        //    public _5d4bfe7c86f7744a9c66b316 _5d4bfe7c86f7744a9c66b316 { get; set; }
        //    public _5a68763786f77474c33a40a1 _5a68763786f77474c33a40a1 { get; set; }
        //    public _5ac5e79986f7747398341847 _5ac5e79986f7747398341847 { get; set; }
        //    public _5ac5e88e86f7741c5804f9db _5ac5e88e86f7741c5804f9db { get; set; }
        //    public _5ac5e98886f77479bc6ca201 _5ac5e98886f77479bc6ca201 { get; set; }
        //    public _5ac5ea0586f774609f36280c _5ac5ea0586f774609f36280c { get; set; }
        //    public _59c50f1686f77412ef2c01e7 _59c50f1686f77412ef2c01e7 { get; set; }
        //    public _5edabb950c502106f869bc04 _5edabb950c502106f869bc04 { get; set; }
        //    public _5edabc2ca0055865214cb5a6 _5edabc2ca0055865214cb5a6 { get; set; }
        //    public _5f04935cde3b9e0ecf03d864 _5f04935cde3b9e0ecf03d864 { get; set; }
        //    public _5f04944b69ef785df740a8c9 _5f04944b69ef785df740a8c9 { get; set; }
        //    public _5f0495458654d20be3564f4c _5f0495458654d20be3564f4c { get; set; }
        //    public _5f0495b8efefac7f7227de63 _5f0495b8efefac7f7227de63 { get; set; }
        //    public _596a0e8086f7741ddd6c104c _596a0e8086f7741ddd6c104c { get; set; }
        //    public _5a68777586f774747d4b0d9e _5a68777586f774747d4b0d9e { get; set; }
        //    public _5d6fb8a886f77449db3db8b6 _5d6fb8a886f77449db3db8b6 { get; set; }
        //    public _5c0be66c86f7744523489ab2 _5c0be66c86f7744523489ab2 { get; set; }
        //    public _5c0be69086f7743c9c1ecf43 _5c0be69086f7743c9c1ecf43 { get; set; }
        //    public _5edac1040880da21347b3845 _5edac1040880da21347b3845 { get; set; }
        //    public _5edac1530880da21347b3846 _5edac1530880da21347b3846 { get; set; }
        //    public _5edac1b2930f5454f51dcac4 _5edac1b2930f5454f51dcac4 { get; set; }
        //    public _5edac1fccc183c769d778bd3 _5edac1fccc183c769d778bd3 { get; set; }
        //    public _5edac2582ddc9e4c802cd970 _5edac2582ddc9e4c802cd970 { get; set; }
        //    public _5edac2a260bdcc7ff3558127 _5edac2a260bdcc7ff3558127 { get; set; }
        //    public _5edac2e10bb72a50635c2bf9 _5edac2e10bb72a50635c2bf9 { get; set; }
        //    public _5c139eb686f7747878361a72 _5c139eb686f7747878361a72 { get; set; }
        //    public _5c139eb686f7747878361a73 _5c139eb686f7747878361a73 { get; set; }
        //    public _5b4c769686f7746e535a5c0e _5b4c769686f7746e535a5c0e { get; set; }
        //    public _5a27ffc786f77415ca58ae47 _5a27ffc786f77415ca58ae47 { get; set; }
        //    public _5a294f3386f77433e923f9cd _5a294f3386f77433e923f9cd { get; set; }
        //    public _5a28023f86f774528903dd1e _5a28023f86f774528903dd1e { get; set; }
        //    public _5ae9b34686f7743129512ccf _5ae9b34686f7743129512ccf { get; set; }
        //    public _5ae9b38a86f77432c81e2ce3 _5ae9b38a86f77432c81e2ce3 { get; set; }
        //    public _5ae9b3c986f77432c81e2ce6 _5ae9b3c986f77432c81e2ce6 { get; set; }
        //    public _5ae4543686f7742dc043c903 _5ae4543686f7742dc043c903 { get; set; }
        //    public _5ae454a086f7742be909a81a _5ae454a086f7742be909a81a { get; set; }
        //    public _5ae9b63286f774229110402d _5ae9b63286f774229110402d { get; set; }
        //    public _5ae455be86f7742dc043c969 _5ae455be86f7742dc043c969 { get; set; }
        //    public _5ae4562086f774498b05e0dc _5ae4562086f774498b05e0dc { get; set; }
        //    public _5b47886986f7744d1a393e65 _5b47886986f7744d1a393e65 { get; set; }
        //}

        public class BodyParts
        {
            public object Head { get; set; }
            public object Chest { get; set; }
            public object Stomach { get; set; }
            public object LeftArm { get; set; }
            public object RightArm { get; set; }
            public object LeftLeg { get; set; }
            public object RightLeg { get; set; }
        }

        public class Bonuse
        {
            public string type { get; set; }
            public string templateId { get; set; }
            public int? value { get; set; }
            public bool? passive { get; set; }
            public bool? production { get; set; }
            public bool? visible { get; set; }
            public string id { get; set; }
            public string icon { get; set; }
            public List<string> filter { get; set; }
            public string skillType { get; set; }
        }

        public class Chest
        {
            public _Health Health { get; set; }
        }

        public class Common
        {
            public override string ToString()
            {
                return Id;
            }
            public string Id { get; set; }
            public double Progress { get; set; }
            public double PointsEarnedDuringSession { get; set; }
            public int LastAccess { get; set; }
        }

        //public class ConditionCounters
        //{
        //    public List<Counter> Counters { get; set; }
        //}

        public class Counter
        {
            public string id { get; set; }
            public int value { get; set; }
            public string qid { get; set; }
        }

        //public class Customization
        //{
        //    public string Body { get; set; }
        //    public string Feet { get; set; }
        //    public string Hands { get; set; }
        //    public string Head { get; set; }
        //}

        public class DamageHistory
        {
            public string LethalDamagePart { get; set; }
            public object LethalDamage { get; set; }
            public BodyParts BodyParts { get; set; }
        }

        public class DeathCause
        {
            public string DamageType { get; set; }
            public string Side { get; set; }
            public string Role { get; set; }
            public string WeaponId { get; set; }
        }

        public class Dogtag
        {
            public string AccountId { get; set; }
            public string ProfileId { get; set; }
            public string Nickname { get; set; }
            public string Side { get; set; }
            public int Level { get; set; }
            public DateTime Time { get; set; }
            public string Status { get; set; }
            public string KillerAccountId { get; set; }
            public string KillerProfileId { get; set; }
            public string KillerName { get; set; }
            public string WeaponName { get; set; }
        }

        public class DroppedItem
        {
            public string QuestId { get; set; }
            public string ItemId { get; set; }
            public string ZoneId { get; set; }
        }

        //public class Encyclopedia
        //{
        //    public bool _56dfef82d2720bbd668b4567 { get; set; }
        //    public bool _57dc324a24597759501edc20 { get; set; }
        //    public bool _57dc334d245977597164366f { get; set; }
        //    public bool _59d36a0086f7747e673f3946 { get; set; }
        //    public bool _590c657e86f77412b013051d { get; set; }
        //    public bool _544fb3f34bdc2d03748b456a { get; set; }
        //    public bool _58864a4f2459770fcc257101 { get; set; }
        //    public bool _5448be9a4bdc2dfd2f8b456a { get; set; }
        //    public bool _544fb45d4bdc2dee738b4568 { get; set; }
        //    public bool _590c678286f77426c9660122 { get; set; }
        //    public bool _5926c3b286f774640d189b6b { get; set; }
        //    public bool _584984812459776a704a82a6 { get; set; }
        //    public bool _59ccfdba86f7747f2109a587 { get; set; }
        //    public bool _545cdae64bdc2d39198b4568 { get; set; }
        //    public bool _5645bc214bdc2d363b8b4571 { get; set; }
        //    public bool _545cdb794bdc2d3a198b456a { get; set; }
        //    public bool _592c2d1a86f7746dbe2af32a { get; set; }
        //    public bool _567143bf4bdc2d1a0f8b4567 { get; set; }
        //    public bool _59bffbb386f77435b379b9c2 { get; set; }
        //    public bool _59bffc1f86f77435b128b872 { get; set; }
        //    public bool _595cf16b86f77427440c32e2 { get; set; }
        //    public bool _5644bd2b4bdc2d3b4c8b4572 { get; set; }
        //    public bool _59c6633186f7740cf0493bb9 { get; set; }
        //    public bool _5649b0544bdc2d1b2b8b458a { get; set; }
        //    public bool _55d482194bdc2d1d4e8b456b { get; set; }
        //    public bool _56d5a2bbd2720bb8418b456a { get; set; }
        //    public bool _56d5a407d2720bb3418b456b { get; set; }
        //    public bool _5926bb2186f7744b1c6c6e60 { get; set; }
        //    public bool _5926c0df86f77462f647f764 { get; set; }
        //    public bool _5926c36d86f77467a92a8629 { get; set; }
        //    public bool _5926d2be86f774134d668e4e { get; set; }
        //    public bool _5926d3c686f77410de68ebc8 { get; set; }
        //    public bool _5926e16e86f7742f5a0f7ecb { get; set; }
        //    public bool _5926c32286f774616e42de99 { get; set; }
        //    public bool _55801eed4bdc2d89578b4588 { get; set; }
        //    public bool _559ba5b34bdc2d1f1a8b4582 { get; set; }
        //    public bool _5887431f2459777e1612938f { get; set; }
        //    public bool _56083e1b4bdc2dc8488b4572 { get; set; }
        //    public bool _56083eab4bdc2d26448b456a { get; set; }
        //    public bool _560e620e4bdc2d724b8b456b { get; set; }
        //    public bool _56ea8222d2720b69698b4567 { get; set; }
        //    public bool _58948c8e86f77409493f7266 { get; set; }
        //    public bool _5894a51286f77426d13baf02 { get; set; }
        //    public bool _5894a5b586f77426d2590767 { get; set; }
        //    public bool _5894a2c386f77427140b8342 { get; set; }
        //    public bool _58949dea86f77409483e16a8 { get; set; }
        //    public bool _5894a42086f77426d2590762 { get; set; }
        //    public bool _5894a73486f77426d259076c { get; set; }
        //    public bool _5894a81786f77427140b8347 { get; set; }
        //    public bool _5894a13e86f7742405482982 { get; set; }
        //    public bool _58949edd86f77409483e16a9 { get; set; }
        //    public bool _55d7217a4bdc2d86028b456d { get; set; }
        //    public bool _557ffd194bdc2d28148b457f { get; set; }
        //    public bool _544a5cde4bdc2d39388b456b { get; set; }
        //    public bool _5857a8bc2459772bad15db29 { get; set; }
        //    public bool _5b44c8ea86f7742d1627baf1 { get; set; }
        //    public bool _564ca99c4bdc2d16268b4589 { get; set; }
        //    public bool _57cd379a24597778e7682ecf { get; set; }
        //    public bool _57dc2fa62459775949412633 { get; set; }
        //    public bool _57dc32dc245977596d4ef3d3 { get; set; }
        //    public bool _57dc347d245977596754e7a1 { get; set; }
        //    public bool _5649ad3f4bdc2df8348b4585 { get; set; }
        //    public bool _5811ce772459770e9e5f9532 { get; set; }
        //    public bool _5894a05586f774094708ef75 { get; set; }
        //    public bool _56d59856d2720bd8418b456a { get; set; }
        //    public bool _56d59948d2720bb7418b4582 { get; set; }
        //    public bool _56d59d3ad2720bdb418b4577 { get; set; }
        //    public bool _56d5a661d2720bd8418b456b { get; set; }
        //    public bool _56d5a77ed2720b90418b4568 { get; set; }
        //    public bool _56d5a1f7d2720bb3418b456a { get; set; }
        //    public bool _5448bd6b4bdc2dfc2f8b4569 { get; set; }
        //    public bool _5448c12b4bdc2d02308b456f { get; set; }
        //    public bool _573718ba2459775a75491131 { get; set; }
        //    public bool _5649b1c04bdc2d16268b457c { get; set; }
        //    public bool _5649af094bdc2df8348b4586 { get; set; }
        //    public bool _5649aa744bdc2ded0b8b457e { get; set; }
        //    public bool _5648b0744bdc2d363b8b4578 { get; set; }
        //    public bool _5696686a4bdc2da3298b456a { get; set; }
        //    public bool _5449016a4bdc2d6f028b456f { get; set; }
        //    public bool _5448fee04bdc2dbc018b4567 { get; set; }
        //    public bool _544fb25a4bdc2dfb738b4567 { get; set; }
        //    public bool _57347d7224597744596b4e72 { get; set; }
        //    public bool _544fb3364bdc2d34748b456a { get; set; }
        //    public bool _5755356824597772cb798962 { get; set; }
        //    public bool _5645bcc04bdc2d363b8b4572 { get; set; }
        //    public bool _5751a25924597722c463c472 { get; set; }
        //    public bool _544fb37f4bdc2dee738b4567 { get; set; }
        //    public bool _5e831507ea0a7c419c2f9bd9 { get; set; }
        //    public bool _5648a7494bdc2d9d488b4583 { get; set; }
        //    public bool _544a11ac4bdc2d470e8b456a { get; set; }
        //    public bool _5c0e9f2c86f77432297fe0a3 { get; set; }
        //    public bool _55d4887d4bdc2d962f8b4570 { get; set; }
        //    public bool _54527a984bdc2d4e668b4567 { get; set; }
        //    public bool _5aa2a7e8e5b5b00016327c16 { get; set; }
        //    public bool _5ab8f39486f7745cd93a1cca { get; set; }
        //    public bool _54491bb74bdc2d09088b4567 { get; set; }
        //    public bool _5447a9cd4bdc2dbd208b4567 { get; set; }
        //    public bool _55d44fd14bdc2d962f8b456e { get; set; }
        //    public bool _5649be884bdc2d79388b4577 { get; set; }
        //    public bool _55d4ae6c4bdc2d8b2f8b456e { get; set; }
        //    public bool _55d355e64bdc2d962f8b4569 { get; set; }
        //    public bool _55d5f46a4bdc2d1b198b4567 { get; set; }
        //    public bool _55d459824bdc2d892f8b4573 { get; set; }
        //    public bool _55d3632e4bdc2d972f8b4569 { get; set; }
        //    public bool _56ea8d2fd2720b7c698b4570 { get; set; }
        //    public bool _55d4af3a4bdc2d972f8b456f { get; set; }
        //    public bool _544a38634bdc2d58388b4568 { get; set; }
        //    public bool _55d4b9964bdc2d1d4e8b456e { get; set; }
        //    public bool _58dd3ad986f77403051cba8f { get; set; }
        //    public bool _5d02778e86f774203e7dedbe { get; set; }
        //    public bool _5bfeaa0f0db834001b734927 { get; set; }
        //    public bool _5d1b371186f774253763a656 { get; set; }
        //    public bool _58d3db5386f77426186285a0 { get; set; }
        //    public bool _5aa7d03ae5b5b00016327db5 { get; set; }
        //    public bool _5c165d832e2216398b5a7e36 { get; set; }
        //    public bool _57c5ac0824597754771e88a9 { get; set; }
        //    public bool _5bfebc5e0db834001a6694e5 { get; set; }
        //    public bool _5bfea6e90db834001b7347f3 { get; set; }
        //    public bool _5bfebc320db8340019668d79 { get; set; }
        //    public bool _5bfeb32b0db834001a6694d9 { get; set; }
        //    public bool _5bfea7ad0db834001c38f1ee { get; set; }
        //    public bool _557ff21e4bdc2d89578b4586 { get; set; }
        //    public bool _5af0454c86f7746bf20992e8 { get; set; }
        //    public bool _5e9dcf5986f7746c417435b3 { get; set; }
        //    public bool _590c5f0d86f77413997acfab { get; set; }
        //    public bool _5c0e655586f774045612eeb2 { get; set; }
        //    public bool _5e870397991fd70db46995c8 { get; set; }
        //    public bool _560d5e524bdc2d25448b4571 { get; set; }
        //    public bool _5e87114fe2db31558c75a120 { get; set; }
        //    public bool _5e87116b81c4ed43e83cefdd { get; set; }
        //    public bool _5e87080c81c4ed43e83cefda { get; set; }
        //    public bool _5e87076ce2db31558c75a11d { get; set; }
        //    public bool _5e87071478f43e51ca2de5e1 { get; set; }
        //    public bool _5e8708d4ae379e67d22e0102 { get; set; }
        //    public bool _5cadc190ae921500103bb3b6 { get; set; }
        //    public bool _5cadc2e0ae9215051e1c21e7 { get; set; }
        //    public bool _5cadc55cae921500103bb3be { get; set; }
        //    public bool _5cadd919ae921500126a77f3 { get; set; }
        //    public bool _5cadd940ae9215051e1c2316 { get; set; }
        //    public bool _5cadc431ae921500113bb8d5 { get; set; }
        //    public bool _5cadc1c6ae9215000f2775a4 { get; set; }
        //    public bool _5cadc390ae921500126a77f1 { get; set; }
        //    public bool _57347da92459774491567cf5 { get; set; }
        //    public bool _5a0c27731526d80618476ac4 { get; set; }
        //    public bool _5d2f213448f0355009199284 { get; set; }
        //    public bool _569668774bdc2da2298b4568 { get; set; }
        //    public bool _5755383e24597772cb798966 { get; set; }
        //    public bool _590c695186f7741e566b64a2 { get; set; }
        //    public bool _5d403f9186f7743cac3f229b { get; set; }
        //    public bool _5e4d34ca86f774264f758330 { get; set; }
        //    public bool _590c661e86f7741e566b646a { get; set; }
        //    public bool _5d02797c86f774203f38e30a { get; set; }
        //    public bool _5c0e530286f7747fa1419862 { get; set; }
        //    public bool _5e8488fa988a8701445df1e4 { get; set; }
        //    public bool _5f4f9eb969cdc30ff33f09db { get; set; }
        //    public bool _5d5e9c74a4b9364855191c40 { get; set; }
        //    public bool _570fd6c2d2720bc6458b457f { get; set; }
        //    public bool _5c488a752e221602b412af63 { get; set; }
        //    public bool _5c48a2852e221602b21d5923 { get; set; }
        //    public bool _5c48a2a42e221602b66d1e07 { get; set; }
        //    public bool _5c48a14f2e2216152006edd7 { get; set; }
        //    public bool _5c48a2c22e221602b313fb6c { get; set; }
        //    public bool _5aafbde786f774389d0cbc0f { get; set; }
        //    public bool _5d5d85c586f774279a21cbdb { get; set; }
        //    public bool _544a5caa4bdc2d1a388b4568 { get; set; }
        //    public bool _5d5d940f86f7742797262046 { get; set; }
        //    public bool _5e2af47786f7746d404f3aaa { get; set; }
        //    public bool _5e2af4a786f7746d3f3c3400 { get; set; }
        //    public bool _5c18b9192e2216398b5a8104 { get; set; }
        //    public bool _5c18b90d2e2216152142466b { get; set; }
        //    public bool _5d1b36a186f7742523398433 { get; set; }
        //    public bool _572b7fa524597762b747ce82 { get; set; }
        //    public bool _5ae30bad5acfc400185c2dc4 { get; set; }
        //    public bool _5ae30db85acfc408fb139a05 { get; set; }
        //    public bool _5ae30e795acfc408fb139a0b { get; set; }
        //}

        public class Energy
        {
            public double Current { get; set; }
            public double Maximum { get; set; }
        }

        public class FastPanel
        {
            public string Item4 { get; set; }
            public string Item5 { get; set; }
            public string Item6 { get; set; }
            public string Item7 { get; set; }
            public string Item8 { get; set; }
            public string Item9 { get; set; }
        }

        public class FoodDrink
        {
            public int HpPercent { get; set; }
        }

        public class Head
        {
            public _Health Health { get; set; }
        }

        public class _Health
        {
            public Hydration Hydration { get; set; }
            public Energy Energy { get; set; }
            public Temperature Temperature { get; set; }
            public BodyParts BodyParts { get; set; }
            public int UpdateTime { get; set; }
            public double Current { get; set; }
            public double Maximum { get; set; }
        }

        //public class Hideout
        //{
        //    public Production Production { get; set; }
        //    public List<object> Areas { get; set; }
        //}

        public class Hydration
        {
            public double Current { get; set; }
            public double Maximum { get; set; }
        }

        public class _Info
        {
            public string Nickname { get; set; }
            public string LowerNickname { get; set; }
            public string Side { get; set; }
            public string Voice { get; set; }
            public int Level { get; set; }
            public int Experience { get; set; }
            public int RegistrationDate { get; set; }
            public string GameVersion { get; set; }
            public int AccountType { get; set; }
            public string MemberCategory { get; set; }
            public bool lockedMoveCommands { get; set; }
            public int SavageLockTime { get; set; }
            public int LastTimePlayedAsSavage { get; set; }
            public Settings Settings { get; set; }
            public bool NeedWipe { get; set; }
            public bool GlobalWipe { get; set; }
            public int NicknameChangeDate { get; set; }
            public List<object> Bans { get; set; }
        }

        public class InsuredItem
        {
            public string tid { get; set; }
            public string itemId { get; set; }
        }

        //public class Inventory
        //{
        //    public string equipment { get; set; }
        //    public FastPanel fastPanel { get; set; }
        //    public List<Item> items { get; set; }
        //    public string questRaidItems { get; set; }
        //    public string questStashItems { get; set; }
        //    public string sortingTable { get; set; }
        //    public string stash { get; set; }
        //}

        public class Item
        {
            public string _id { get; set; }
            public string _tpl { get; set; }
            public object location { get; set; }
            public string parentId { get; set; }
            public string slotId { get; set; }
            public Upd upd { get; set; }
        }

        public class Item2
        {
            public List<string> Key { get; set; }
            public int Value { get; set; }
        }

        public class Item4
        {
            public string _id { get; set; }
            public string _tpl { get; set; }
            public Upd upd { get; set; }
        }

        public class Key
        {
            public int NumberOfUsages { get; set; }
        }

        public class LeftArm
        {
            public _Health Health { get; set; }
            public double Amount { get; set; }
            public string Type { get; set; }
            public string SourceId { get; set; }
            public string OverDamageFrom { get; set; }
            public bool Blunt { get; set; }
            public int ImpactsCount { get; set; }
        }

        public class LeftLeg
        {
            public _Health Health { get; set; }
        }

        public class Location
        {
            public int x { get; set; }
            public int y { get; set; }
            public string r { get; set; }
            public bool isSearched { get; set; }
        }

        public class Mastering
        {
            public string Id { get; set; }
            public int Progress { get; set; }
        }

        public class MedKit
        {
            public int HpResource { get; set; }
        }

        //public class Notes
        //{
        //    public List<object> notes { get; set; }
        //}

        public class OverallCounters
        {
            public List<Item> Items { get; set; }
        }

        public class Production
        {
            public _5d5c205bd582a50d042a3c0e _5d5c205bd582a50d042a3c0e { get; set; }
        }

        public class Quest
        {
            public string qid { get; set; }
            public int startTime { get; set; }
            public string status { get; set; }
            public object statusTimers { get; set; }
            public object completedConditions { get; set; }
        }

        public class Ragfair
        {
            public int salesSum { get; set; }
            public int standing { get; set; }
            public bool unlocked { get; set; }
        }

        public class _RagfairInfo
        {
            public double rating { get; set; }
            public bool isRatingGrowing { get; set; }
            public List<object> offers { get; set; }
        }

        public class Resource
        {
            public int Value { get; set; }
        }

        public class RightArm
        {
            public _Health Health { get; set; }
            public double Amount { get; set; }
            public string Type { get; set; }
            public string SourceId { get; set; }
            public object OverDamageFrom { get; set; }
            public bool Blunt { get; set; }
            public int ImpactsCount { get; set; }
        }

        public class RightLeg
        {
            public _Health Health { get; set; }
        }

        public class SessionCounters
        {
            public List<Item> Items { get; set; }
        }

        public class Settings
        {
            public string Role { get; set; }
            public string BotDifficulty { get; set; }
            public int Experience { get; set; }
        }

        public class _Skills
        {
            public List<Common> Common { get; set; }
            public List<Mastering> Mastering { get; set; }
            public object Bonuses { get; set; }
            public int Points { get; set; }
        }

        public class Slot
        {
            public List<Item> item { get; set; }
        }

        public class _Stats
        {
            public SessionCounters SessionCounters { get; set; }
            public OverallCounters OverallCounters { get; set; }
            public double SessionExperienceMult { get; set; }
            public double ExperienceBonusMult { get; set; }
            public int TotalSessionExperience { get; set; }
            public int LastSessionDate { get; set; }
            public Aggressor Aggressor { get; set; }
            public List<DroppedItem> DroppedItems { get; set; }
            public List<object> FoundInRaidItems { get; set; }
            public List<Victim> Victims { get; set; }
            public List<string> CarriedQuestItems { get; set; }
            public DamageHistory DamageHistory { get; set; }
            public DeathCause DeathCause { get; set; }
            public object LastPlayerState { get; set; }
            public int TotalInGameTime { get; set; }
            public string SurvivorClass { get; set; }
        }

        public class StatusTimers
        {
            public double AvailableForStart { get; set; }
            public double Started { get; set; }
            public double AvailableForFinish { get; set; }
            public double? Success { get; set; }
            public double? Fail { get; set; }
        }

        public class Stomach
        {
            public _Health Health { get; set; }
        }

        public class Temperature
        {
            public double Current { get; set; }
            public double Maximum { get; set; }
        }

        public class _TradersInfo
        {
            public _54cb50c76803fa8b248b4571 _54cb50c76803fa8b248b4571 { get; set; }
            public _5a7c2eca46aef81a7ca2145d _5a7c2eca46aef81a7ca2145d { get; set; }
            public _5c0647fdd443bc2504c2d371 _5c0647fdd443bc2504c2d371 { get; set; }
            public Ragfair ragfair { get; set; }
            public _5ac3b934156ae10c4430e83c _5ac3b934156ae10c4430e83c { get; set; }
            public _54cb57776803fa99248b456e _54cb57776803fa99248b456e { get; set; }
            public _58330581ace78e27b8b10cee _58330581ace78e27b8b10cee { get; set; }
            public _5935c25fb3acc3127c3d8cd9 _5935c25fb3acc3127c3d8cd9 { get; set; }
            public _579dc571d53a0658a154fbec _579dc571d53a0658a154fbec { get; set; }
        }

        public class Upd
        {
            public int StackObjectsCount { get; set; }
            public MedKit MedKit { get; set; }
            public FoodDrink FoodDrink { get; set; }
            public bool? SpawnedInSession { get; set; }
            public Key Key { get; set; }
            public Resource Resource { get; set; }
            public Dogtag Dogtag { get; set; }
        }

        public class Victim
        {
            public string AccountId { get; set; }
            public string ProfileId { get; set; }
            public string Name { get; set; }
            public string Side { get; set; }
            public string Time { get; set; }
            public int Level { get; set; }
            public string BodyPart { get; set; }
            public string Weapon { get; set; }
            public double Distance { get; set; }
            public string Role { get; set; }
        }


    }
}
