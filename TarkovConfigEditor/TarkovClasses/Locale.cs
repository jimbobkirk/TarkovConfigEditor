using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarkovConfigEditor.TarkovClasses
{
    public class Locale
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

        public Banners banners { get; set; }
        public Customization customization { get; set; }
        public List<object> @enum { get; set; }
        public Error error { get; set; }
        public Handbook handbook { get; set; }
        //public Interface @interface { get; set; }
        //public Locations locations { get; set; }
        //public Mail mail { get; set; }
        //public Preset preset { get; set; }
        public Quest quest { get; set; }
        //public RepeatableQuest repeatableQuest { get; set; }
        //public Season season { get; set; }
        //public Templates templates { get; set; }
        //public Trading trading { get; set; }


        public class Quest
        {
            public _5936d90786f7742b1420ba5b _5936d90786f7742b1420ba5b { get; set; }
            public _5936da9e86f7742d65037edf _5936da9e86f7742d65037edf { get; set; }
            public _59674cd986f7744ab26e32f2 _59674cd986f7744ab26e32f2 { get; set; }
            public _59674eb386f774539f14813a _59674eb386f774539f14813a { get; set; }
            public _5967530a86f77462ba22226b _5967530a86f77462ba22226b { get; set; }
            public _59675d6c86f7740a842fc482 _59675d6c86f7740a842fc482 { get; set; }
            public _59675ea386f77414b32bded2 _59675ea386f77414b32bded2 { get; set; }
            public _596760e186f7741e11214d58 _596760e186f7741e11214d58 { get; set; }
            public _5967725e86f774601a446662 _5967725e86f774601a446662 { get; set; }
            public _5967733e86f774602332fc84 _5967733e86f774602332fc84 { get; set; }
            public _59689ee586f7740d1570bbd5 _59689ee586f7740d1570bbd5 { get; set; }
            public _59689fbd86f7740d137ebfc4 _59689fbd86f7740d137ebfc4 { get; set; }
            public _5968eb3186f7741dde183a4d _5968eb3186f7741dde183a4d { get; set; }
            public _5969f90786f77420d2328015 _5969f90786f77420d2328015 { get; set; }
            public _5969f9e986f7741dde183a50 _5969f9e986f7741dde183a50 { get; set; }
            public _596a0e1686f7741ddf17dbee _596a0e1686f7741ddf17dbee { get; set; }
            public _596a101f86f7741ddb481582 _596a101f86f7741ddb481582 { get; set; }
            public _596a1e6c86f7741ddc2d3206 _596a1e6c86f7741ddc2d3206 { get; set; }
            public _596a204686f774576d4c95de _596a204686f774576d4c95de { get; set; }
            public _596a218586f77420d232807c _596a218586f77420d232807c { get; set; }
            public _596b36c586f77450d6045ad2 _596b36c586f77450d6045ad2 { get; set; }
            public _596b43fb86f77457ca186186 _596b43fb86f77457ca186186 { get; set; }
            public _596b455186f77457cb50eccb _596b455186f77457cb50eccb { get; set; }
            public _5979ed3886f77431307dc512 _5979ed3886f77431307dc512 { get; set; }
            public _5979eee086f774311955e614 _5979eee086f774311955e614 { get; set; }
            public _5979f8bb86f7743ec214c7a6 _5979f8bb86f7743ec214c7a6 { get; set; }
            public _5979f9ba86f7740f6c3fe9f2 _5979f9ba86f7740f6c3fe9f2 { get; set; }
            public _597a0b2986f77426d66c0633 _597a0b2986f77426d66c0633 { get; set; }
            public _597a0e5786f77426d66c0636 _597a0e5786f77426d66c0636 { get; set; }
            public _597a0f5686f774273b74f676 _597a0f5686f774273b74f676 { get; set; }
            public _597a160786f77477531d39d2 _597a160786f77477531d39d2 { get; set; }
            public _597a171586f77405ba6887d3 _597a171586f77405ba6887d3 { get; set; }
            public _59c124d686f774189b3c843f _59c124d686f774189b3c843f { get; set; }
            public _59c50a9e86f7745fef66f4ff _59c50a9e86f7745fef66f4ff { get; set; }
            public _59c50c8886f7745fed3193bf _59c50c8886f7745fed3193bf { get; set; }
            public _59c512ad86f7741f0d09de9b _59c512ad86f7741f0d09de9b { get; set; }
            public _59c9392986f7742f6923add2 _59c9392986f7742f6923add2 { get; set; }
            public _59c93e8e86f7742a406989c4 _59c93e8e86f7742a406989c4 { get; set; }
            public _59ca1a6286f774509a270942 _59ca1a6286f774509a270942 { get; set; }
            public _59ca264786f77445a80ed044 _59ca264786f77445a80ed044 { get; set; }
            public _59ca29fb86f77445ab465c87 _59ca29fb86f77445ab465c87 { get; set; }
            public _59ca2eb686f77445a80ed049 _59ca2eb686f77445a80ed049 { get; set; }
            public _59f9da6786f774714230d751 _59f9da6786f774714230d751 { get; set; }
            public _5a03153686f77442d90e2171 _5a03153686f77442d90e2171 { get; set; }
            public _5a03173786f77451cb427172 _5a03173786f77451cb427172 { get; set; }
            public _5a0327ba86f77456b9154236 _5a0327ba86f77456b9154236 { get; set; }
            public _5a03296886f774569778596a _5a03296886f774569778596a { get; set; }
            public _5a0449d586f77474e66227b7 _5a0449d586f77474e66227b7 { get; set; }
            public _5a27b75b86f7742e97191958 _5a27b75b86f7742e97191958 { get; set; }
            public _5a27b7a786f774579c3eb376 _5a27b7a786f774579c3eb376 { get; set; }
            public _5a27b7d686f77460d847e6a6 _5a27b7d686f77460d847e6a6 { get; set; }
            public _5a27b80086f774429a5d7e20 _5a27b80086f774429a5d7e20 { get; set; }
            public _5a27b87686f77460de0252a8 _5a27b87686f77460de0252a8 { get; set; }
            public _5a27b9de86f77464e5044585 _5a27b9de86f77464e5044585 { get; set; }
            public _5a27ba1c86f77461ea5a3c56 _5a27ba1c86f77461ea5a3c56 { get; set; }
            public _5a27ba9586f7741b543d8e85 _5a27ba9586f7741b543d8e85 { get; set; }
            public _5a27bafb86f7741c73584017 _5a27bafb86f7741c73584017 { get; set; }
            public _5a27bb1e86f7741f27621b7e _5a27bb1e86f7741f27621b7e { get; set; }
            public _5a27bb3d86f77411ea361a21 _5a27bb3d86f77411ea361a21 { get; set; }
            public _5a27bb5986f7741dfb660900 _5a27bb5986f7741dfb660900 { get; set; }
            public _5a27bb8386f7741c770d2d0a _5a27bb8386f7741c770d2d0a { get; set; }
            public _5a27bbf886f774333a418eeb _5a27bbf886f774333a418eeb { get; set; }
            public _5a27bc1586f7741f6d40fa2f _5a27bc1586f7741f6d40fa2f { get; set; }
            public _5a27bc3686f7741c73584026 _5a27bc3686f7741c73584026 { get; set; }
            public _5a27bc6986f7741c7358402b _5a27bc6986f7741c7358402b { get; set; }
            public _5a27bc8586f7741b543d8ea4 _5a27bc8586f7741b543d8ea4 { get; set; }
            public _5a27c99a86f7747d2c6bdd8e _5a27c99a86f7747d2c6bdd8e { get; set; }
            public _5a27d2af86f7744e1115b323 _5a27d2af86f7744e1115b323 { get; set; }
            public _5a5642ce86f77445c63c3419 _5a5642ce86f77445c63c3419 { get; set; }
            public _5a68661a86f774500f48afb0 _5a68661a86f774500f48afb0 { get; set; }
            public _5a68663e86f774501078f78a _5a68663e86f774501078f78a { get; set; }
            public _5a68665c86f774255929b4c7 _5a68665c86f774255929b4c7 { get; set; }
            public _5a68667486f7742607157d28 _5a68667486f7742607157d28 { get; set; }
            public _5a68669a86f774255929b4d4 _5a68669a86f774255929b4d4 { get; set; }
            public _5ac23c6186f7741247042bad _5ac23c6186f7741247042bad { get; set; }
            public _5ac2426c86f774138762edfe _5ac2426c86f774138762edfe { get; set; }
            public _5ac2428686f77412450b42bf _5ac2428686f77412450b42bf { get; set; }
            public _5ac242ab86f77412464f68b4 _5ac242ab86f77412464f68b4 { get; set; }
            public _5ac244c486f77413e12cf945 _5ac244c486f77413e12cf945 { get; set; }
            public _5ac244eb86f7741356335af1 _5ac244eb86f7741356335af1 { get; set; }
            public _5ac345dc86f774288030817f _5ac345dc86f774288030817f { get; set; }
            public _5ac3460c86f7742880308185 _5ac3460c86f7742880308185 { get; set; }
            public _5ac3462b86f7741d6118b983 _5ac3462b86f7741d6118b983 { get; set; }
            public _5ac3464c86f7741d651d6877 _5ac3464c86f7741d651d6877 { get; set; }
            public _5ac3467986f7741d6224abc2 _5ac3467986f7741d6224abc2 { get; set; }
            public _5ac346a886f7744e1b083d67 _5ac346a886f7744e1b083d67 { get; set; }
            public _5ac346cf86f7741d63233a02 _5ac346cf86f7741d63233a02 { get; set; }
            public _5ac346e886f7741d6118b99b _5ac346e886f7741d6118b99b { get; set; }
            public _5ac3475486f7741d6224abd3 _5ac3475486f7741d6224abd3 { get; set; }
            public _5ac3477486f7741d651d6885 _5ac3477486f7741d651d6885 { get; set; }
            public _5ac3479086f7742880308199 _5ac3479086f7742880308199 { get; set; }
            public _5ae3267986f7742a413592fe _5ae3267986f7742a413592fe { get; set; }
            public _5ae3270f86f77445ba41d4dd _5ae3270f86f77445ba41d4dd { get; set; }
            public _5ae3277186f7745973054106 _5ae3277186f7745973054106 { get; set; }
            public _5ae327c886f7745c7b3f2f3f _5ae327c886f7745c7b3f2f3f { get; set; }
            public _5ae3280386f7742a41359364 _5ae3280386f7742a41359364 { get; set; }
            public _5ae448a386f7744d3730fff0 _5ae448a386f7744d3730fff0 { get; set; }
            public _5ae448bf86f7744d733e55ee _5ae448bf86f7744d733e55ee { get; set; }
            public _5ae448e586f7744dcf0c2a67 _5ae448e586f7744dcf0c2a67 { get; set; }
            public _5ae448f286f77448d73c0131 _5ae448f286f77448d73c0131 { get; set; }
            public _5ae4490786f7744ca822adcc _5ae4490786f7744ca822adcc { get; set; }
            public _5ae4493486f7744efa289417 _5ae4493486f7744efa289417 { get; set; }
            public _5ae4493d86f7744b8e15aa8f _5ae4493d86f7744b8e15aa8f { get; set; }
            public _5ae4495086f77443c122bc40 _5ae4495086f77443c122bc40 { get; set; }
            public _5ae4495c86f7744e87761355 _5ae4495c86f7744e87761355 { get; set; }
            public _5ae4496986f774459e77beb6 _5ae4496986f774459e77beb6 { get; set; }
            public _5ae4497b86f7744cf402ed00 _5ae4497b86f7744cf402ed00 { get; set; }
            public _5ae4498786f7744bde357695 _5ae4498786f7744bde357695 { get; set; }
            public _5ae4499a86f77449783815db _5ae4499a86f77449783815db { get; set; }
            public _5ae449a586f7744bde357696 _5ae449a586f7744bde357696 { get; set; }
            public _5ae449b386f77446d8741719 _5ae449b386f77446d8741719 { get; set; }
            public _5ae449c386f7744bde357697 _5ae449c386f7744bde357697 { get; set; }
            public _5ae449d986f774453a54a7e1 _5ae449d986f774453a54a7e1 { get; set; }
            public _5b47749f86f7746c5d6a5fd4 _5b47749f86f7746c5d6a5fd4 { get; set; }
            public _5b47799d86f7746c5d6a5fd8 _5b47799d86f7746c5d6a5fd8 { get; set; }
            public _5b477b6f86f7747290681823 _5b477b6f86f7747290681823 { get; set; }
            public _5b477f7686f7744d1b23c4d2 _5b477f7686f7744d1b23c4d2 { get; set; }
            public _5b47825886f77468074618d3 _5b47825886f77468074618d3 { get; set; }
            public _5b47876e86f7744d1c353205 _5b47876e86f7744d1c353205 { get; set; }
            public _5b47891f86f7744d1b23c571 _5b47891f86f7744d1b23c571 { get; set; }
            public _5b478b1886f7744d1b23c57d _5b478b1886f7744d1b23c57d { get; set; }
            public _5b478d0f86f7744d190d91b5 _5b478d0f86f7744d190d91b5 { get; set; }
            public _5b478eca86f7744642012254 _5b478eca86f7744642012254 { get; set; }
            public _5b478ff486f7744d184ecbbf _5b478ff486f7744d184ecbbf { get; set; }
            public _5b47926a86f7747ccc057c15 _5b47926a86f7747ccc057c15 { get; set; }
            public _5b4794cb86f774598100d5d4 _5b4794cb86f774598100d5d4 { get; set; }
            public _5b4795fb86f7745876267770 _5b4795fb86f7745876267770 { get; set; }
            public _5bc4776586f774512d07cf05 _5bc4776586f774512d07cf05 { get; set; }
            public _5bc479e586f7747f376c7da3 _5bc479e586f7747f376c7da3 { get; set; }
            public _5bc47dbf86f7741ee74e93b9 _5bc47dbf86f7741ee74e93b9 { get; set; }
            public _5bc480a686f7741af0342e29 _5bc480a686f7741af0342e29 { get; set; }
            public _5bc4826c86f774106d22d88b _5bc4826c86f774106d22d88b { get; set; }
            public _5bc4836986f7740c0152911c _5bc4836986f7740c0152911c { get; set; }
            public _5bc4856986f77454c317bea7 _5bc4856986f77454c317bea7 { get; set; }
            public _5bc4893c86f774626f5ebf3e _5bc4893c86f774626f5ebf3e { get; set; }
            public _5c0bbaa886f7746941031d82 _5c0bbaa886f7746941031d82 { get; set; }
            public _5c0bc91486f7746ab41857a2 _5c0bc91486f7746ab41857a2 { get; set; }
            public _5c0bd01e86f7747cdd799e56 _5c0bd01e86f7747cdd799e56 { get; set; }
            public _5c0bd94186f7747a727f09b2 _5c0bd94186f7747a727f09b2 { get; set; }
            public _5c0bdb5286f774166e38eed4 _5c0bdb5286f774166e38eed4 { get; set; }
            public _5c0bde0986f77479cf22c2f8 _5c0bde0986f77479cf22c2f8 { get; set; }
            public _5c0be13186f7746f016734aa _5c0be13186f7746f016734aa { get; set; }
            public _5c0be5fc86f774467a116593 _5c0be5fc86f774467a116593 { get; set; }
            public _5c0d0d5086f774363760aef2 _5c0d0d5086f774363760aef2 { get; set; }
            public _5c0d0f1886f77457b8210226 _5c0d0f1886f77457b8210226 { get; set; }
            public _5c0d190cd09282029f5390d8 _5c0d190cd09282029f5390d8 { get; set; }
            public _5c0d1c4cd0928202a02a6f5c _5c0d1c4cd0928202a02a6f5c { get; set; }
            public _5c0d4c12d09282029f539173 _5c0d4c12d09282029f539173 { get; set; }
            public _5c0d4e61d09282029f53920e _5c0d4e61d09282029f53920e { get; set; }
            public _5c10f94386f774227172c572 _5c10f94386f774227172c572 { get; set; }
            public _5c1128e386f7746565181106 _5c1128e386f7746565181106 { get; set; }
            public _5c112d7e86f7740d6f647486 _5c112d7e86f7740d6f647486 { get; set; }
            public _5c1141f386f77430ff393792 _5c1141f386f77430ff393792 { get; set; }
            public _5c1234c286f77406fa13baeb _5c1234c286f77406fa13baeb { get; set; }
            public _5c12452c86f7744b83469073 _5c12452c86f7744b83469073 { get; set; }
            public _5c139eb686f7747878361a6f _5c139eb686f7747878361a6f { get; set; }
            public _5c51aac186f77432ea65c552 _5c51aac186f77432ea65c552 { get; set; }
            public _5d2495a886f77425cd51e403 _5d2495a886f77425cd51e403 { get; set; }
            public _5d24b81486f77439c92d6ba8 _5d24b81486f77439c92d6ba8 { get; set; }
            public _5d25aed386f77442734d25d2 _5d25aed386f77442734d25d2 { get; set; }
            public _5d25b6be86f77444001e1b89 _5d25b6be86f77444001e1b89 { get; set; }
            public _5d25bfd086f77442734d3007 _5d25bfd086f77442734d3007 { get; set; }
            public _5d25c81b86f77443e625dd71 _5d25c81b86f77443e625dd71 { get; set; }
            public _5d25cf2686f77443e75488d4 _5d25cf2686f77443e75488d4 { get; set; }
            public _5d25d2c186f77443e35162e5 _5d25d2c186f77443e35162e5 { get; set; }
            public _5d25dae186f77443e55d2f78 _5d25dae186f77443e55d2f78 { get; set; }
            public _5d25e29d86f7740a22516326 _5d25e29d86f7740a22516326 { get; set; }
            public _5d25e2a986f77409dd5cdf2a _5d25e2a986f77409dd5cdf2a { get; set; }
            public _5d25e2b486f77409de05bba0 _5d25e2b486f77409de05bba0 { get; set; }
            public _5d25e2c386f77443e7549029 _5d25e2c386f77443e7549029 { get; set; }
            public _5d25e2cc86f77443e47ae019 _5d25e2cc86f77443e47ae019 { get; set; }
            public _5d25e2d886f77442734d335e _5d25e2d886f77442734d335e { get; set; }
            public _5d25e2e286f77444001e2e48 _5d25e2e286f77444001e2e48 { get; set; }
            public _5d25e2ee86f77443e35162ea _5d25e2ee86f77443e35162ea { get; set; }
            public _5d25e43786f7740a212217fa _5d25e43786f7740a212217fa { get; set; }
            public _5d25e44386f77409453bce7b _5d25e44386f77409453bce7b { get; set; }
            public _5d25e44f86f77443e625e385 _5d25e44f86f77443e625e385 { get; set; }
            public _5d25e45e86f77408251c4bfa _5d25e45e86f77408251c4bfa { get; set; }
            public _5d25e46e86f77409453bce7c _5d25e46e86f77409453bce7c { get; set; }
            public _5d25e48186f77443e625e386 _5d25e48186f77443e625e386 { get; set; }
            public _5d25e48d86f77408251c4bfb _5d25e48d86f77408251c4bfb { get; set; }
            public _5d25e4ad86f77443e625e387 _5d25e4ad86f77443e625e387 { get; set; }
            public _5d25e4b786f77408251c4bfc _5d25e4b786f77408251c4bfc { get; set; }
            public _5d25e4ca86f77409dd5cdf2c _5d25e4ca86f77409dd5cdf2c { get; set; }
            public _5d25e4d586f77443e625e388 _5d25e4d586f77443e625e388 { get; set; }
            public _5d4bec3486f7743cac246665 _5d4bec3486f7743cac246665 { get; set; }
            public _5d6fb2c086f77449da599c24 _5d6fb2c086f77449da599c24 { get; set; }
            public _5d6fbc2886f77449d825f9d3 _5d6fbc2886f77449d825f9d3 { get; set; }
            public _5dc53acb86f77469c740c893 _5dc53acb86f77469c740c893 { get; set; }
            public _5e381b0286f77420e3417a74 _5e381b0286f77420e3417a74 { get; set; }
            public _5e383a6386f77465910ce1f3 _5e383a6386f77465910ce1f3 { get; set; }
            public _5e4d4ac186f774264f758336 _5e4d4ac186f774264f758336 { get; set; }
            public _5e4d515e86f77438b2195244 _5e4d515e86f77438b2195244 { get; set; }
            public _5e73519b0b997b5e887e59b3 _5e73519b0b997b5e887e59b3 { get; set; }
            public _5e748327dbe23170e05094f4 _5e748327dbe23170e05094f4 { get; set; }
            public _5e748d226725d419a47e2101 _5e748d226725d419a47e2101 { get; set; }
            public _5e748d9fc73f9622610abb37 _5e748d9fc73f9622610abb37 { get; set; }
            public _5e748df9c73f9622610abb38 _5e748df9c73f9622610abb38 { get; set; }
            public _5e748e8fa848081e986a58a2 _5e748e8fa848081e986a58a2 { get; set; }
            public _5e74921dc73f9622610abb3e _5e74921dc73f9622610abb3e { get; set; }
            public _5e7492c2cdcce040bf508424 _5e7492c2cdcce040bf508424 { get; set; }
            public _5e7493d5c377f60fe17d6ec8 _5e7493d5c377f60fe17d6ec8 { get; set; }
            public _5e749741dec1852497081e69 _5e749741dec1852497081e69 { get; set; }
            public _5e749800e80d6c7ea20e93de _5e749800e80d6c7ea20e93de { get; set; }
            public _5e7498198f3a2f53cc477e99 _5e7498198f3a2f53cc477e99 { get; set; }
            public _5e7498cc2eb35c76f5087a47 _5e7498cc2eb35c76f5087a47 { get; set; }
            public _5e74990c647a0846684a1db4 _5e74990c647a0846684a1db4 { get; set; }
            public _5e74a68870d454700576d1fe _5e74a68870d454700576d1fe { get; set; }
            public _5e74a765c377f60fe17d6edb _5e74a765c377f60fe17d6edb { get; set; }
            public _5e74a8a9dfc5fc63e27a781a _5e74a8a9dfc5fc63e27a781a { get; set; }
            public _5e74a9be70d454700576d1ff _5e74a9be70d454700576d1ff { get; set; }
            public _5e74aafac377f60fe17d6ede _5e74aafac377f60fe17d6ede { get; set; }
            public _5e74ac3f70d454700576d200 _5e74ac3f70d454700576d200 { get; set; }
            public _5e74ad13647a0846684a1dc8 _5e74ad13647a0846684a1dc8 { get; set; }
            public _5e74b1b201e03f5a8d48aff9 _5e74b1b201e03f5a8d48aff9 { get; set; }
            public _5e74be4c24c2c642fa612776 _5e74be4c24c2c642fa612776 { get; set; }
            public _5e74be7b258b0422556b70d7 _5e74be7b258b0422556b70d7 { get; set; }
            public _5e85e1d15549dd01fe748b5a _5e85e1d15549dd01fe748b5a { get; set; }
            public _5e85e2fa5549dd01fe748b5b _5e85e2fa5549dd01fe748b5b { get; set; }
            public _5e85e40d5549dd10225137b9 _5e85e40d5549dd10225137b9 { get; set; }
            public _5e85e5025549dda42377fa7b _5e85e5025549dda42377fa7b { get; set; }
            public _5e85e77e5549ddf8e2131c0b _5e85e77e5549ddf8e2131c0b { get; set; }
            public _5eaaaa7c93afa0558f3b5a1c _5eaaaa7c93afa0558f3b5a1c { get; set; }
            public _5eda19f0edce541157209cee _5eda19f0edce541157209cee { get; set; }
            public _5edab4b1218d181e29451435 _5edab4b1218d181e29451435 { get; set; }
            public _5edab736cc183c769d778bc2 _5edab736cc183c769d778bc2 { get; set; }
            public _5edaba7c0c502106f869bc02 _5edaba7c0c502106f869bc02 { get; set; }
            public _5edabd13218d181e29451442 _5edabd13218d181e29451442 { get; set; }
            public _5edac020218d181e29451446 _5edac020218d181e29451446 { get; set; }
            public _5edac34d0bb72a50635c2bfa _5edac34d0bb72a50635c2bfa { get; set; }
            public _5edac63b930f5454f51e128b _5edac63b930f5454f51e128b { get; set; }
            public _5ede55112c95834b583f052a _5ede55112c95834b583f052a { get; set; }
            public _5ede567cfa6dc072ce15d6e3 _5ede567cfa6dc072ce15d6e3 { get; set; }
            public _5f04886a3937dc337a6b8238 _5f04886a3937dc337a6b8238 { get; set; }
            public _5f70abfae9f14826bf7c1c65 _5f70abfae9f14826bf7c1c65 { get; set; }
            public _5f70acb63a7ec37e73013427 _5f70acb63a7ec37e73013427 { get; set; }
            public _5f70b9cfe9f14826bf7c1c67 _5f70b9cfe9f14826bf7c1c67 { get; set; }
            public _5f70e2a5dcfde927745eb1d0 _5f70e2a5dcfde927745eb1d0 { get; set; }
            public _5f710f7ce9f14826bf7c1c72 _5f710f7ce9f14826bf7c1c72 { get; set; }
            public _5f75c5078fb5c37ce1766e95 _5f75c5078fb5c37ce1766e95 { get; set; }
            public _5f75c578dfacb47e146a0062 _5f75c578dfacb47e146a0062 { get; set; }
            public _5f75fb988fb5c37ce1766e98 _5f75fb988fb5c37ce1766e98 { get; set; }
            public _5f75fd4450914c5fcc425279 _5f75fd4450914c5fcc425279 { get; set; }
            public _5f75fddbd24e8b7a9c508f3a _5f75fddbd24e8b7a9c508f3a { get; set; }
            public _5f79c7621f644f1eb53bdaf2 _5f79c7621f644f1eb53bdaf2 { get; set; }
            public _5fd9fad9c1ce6b1a3b486d00 _5fd9fad9c1ce6b1a3b486d00 { get; set; }
            public _600302d73b897b11364cd161 _600302d73b897b11364cd161 { get; set; }
            public _6086c852c945025d41566124 _6086c852c945025d41566124 { get; set; }
            public _60896888e4a85c72ef3fa300 _60896888e4a85c72ef3fa300 { get; set; }
            public _60896b7bfa70fc097863b8f5 _60896b7bfa70fc097863b8f5 { get; set; }
            public _60896bca6ee58f38c417d4f2 _60896bca6ee58f38c417d4f2 { get; set; }
            public _60896e28e4a85c72ef3fa301 _60896e28e4a85c72ef3fa301 { get; set; }
            public _6089732b59b92115597ad789 _6089732b59b92115597ad789 { get; set; }
            public _6089736efa70fc097863b8f6 _6089736efa70fc097863b8f6 { get; set; }
            public _6089743983426423753cd58a _6089743983426423753cd58a { get; set; }
            public _608974af4b05530f55550c21 _608974af4b05530f55550c21 { get; set; }
            public _608974d01a66564e74191fc0 _608974d01a66564e74191fc0 { get; set; }
            public _608a768d82e40b3c727fd17d _608a768d82e40b3c727fd17d { get; set; }
            public _60c0c018f7afb4354815096a _60c0c018f7afb4354815096a { get; set; }
            public _60e71b62a0beca400d69efc4 _60e71b62a0beca400d69efc4 { get; set; }
            public _60e71b9bbd90872cb85440f3 _60e71b9bbd90872cb85440f3 { get; set; }
            public _60e71bb4e456d449cd47ca75 _60e71bb4e456d449cd47ca75 { get; set; }
            public _60e71c11d54b755a3b53eb65 _60e71c11d54b755a3b53eb65 { get; set; }
            public _60e71c48c1bfa3050473b8e5 _60e71c48c1bfa3050473b8e5 { get; set; }
            public _60e71c9ad54b755a3b53eb66 _60e71c9ad54b755a3b53eb66 { get; set; }
            public _60e71ccb5688f6424c7bfec4 _60e71ccb5688f6424c7bfec4 { get; set; }
            public _60e71ce009d7c801eb0c0ec6 _60e71ce009d7c801eb0c0ec6 { get; set; }
            public _60e71d23c1bfa3050473b8e6 _60e71d23c1bfa3050473b8e6 { get; set; }
            public _60e71d6d7fcf9c556f325055 _60e71d6d7fcf9c556f325055 { get; set; }
            public _60e71dc0a94be721b065bbfc _60e71dc0a94be721b065bbfc { get; set; }
            public _60e71dc67fcf9c556f325056 _60e71dc67fcf9c556f325056 { get; set; }
            public _60e71e8ed54b755a3b53eb67 _60e71e8ed54b755a3b53eb67 { get; set; }
            public _60e729cf5698ee7b05057439 _60e729cf5698ee7b05057439 { get; set; }
            public _60effd818b669d08a35bfad5 _60effd818b669d08a35bfad5 { get; set; }
            public _613708a7f8333a5d15594368 _613708a7f8333a5d15594368 { get; set; }
            public _6179ac7511973d018217d0b9 _6179ac7511973d018217d0b9 { get; set; }
            public _6179acbdc760af5ad2053585 _6179acbdc760af5ad2053585 { get; set; }
            public _6179ad0a6e9dd54ac275e3f2 _6179ad0a6e9dd54ac275e3f2 { get; set; }
            public _6179ad56c760af5ad2053587 _6179ad56c760af5ad2053587 { get; set; }
            public _6179ad74bca27a099552e03a _6179ad74bca27a099552e03a { get; set; }
            public _6179afd0bca27a099552e040 _6179afd0bca27a099552e040 { get; set; }
            public _6179aff8f57fb279792c60a1 _6179aff8f57fb279792c60a1 { get; set; }
            public _6179b3a12153c15e937d52bc _6179b3a12153c15e937d52bc { get; set; }
            public _6179b3bdc7560e13d23eeb8d _6179b3bdc7560e13d23eeb8d { get; set; }
            public _6179b4d1bca27a099552e04e _6179b4d1bca27a099552e04e { get; set; }
            public _6179b4f16e9dd54ac275e407 _6179b4f16e9dd54ac275e407 { get; set; }
            public _6179b5b06e9dd54ac275e409 _6179b5b06e9dd54ac275e409 { get; set; }
            public _6179b5eabca27a099552e052 _6179b5eabca27a099552e052 { get; set; }
            public _61904daa7d0d857927447b9c _61904daa7d0d857927447b9c { get; set; }
            public _6193850f60b34236ee0483de _6193850f60b34236ee0483de { get; set; }
            public _61958c366726521dd96828ec _61958c366726521dd96828ec { get; set; }
            public _61bb468b8d7cac1532300ccc _61bb468b8d7cac1532300ccc { get; set; }
            public _61bb47481908c67d4249a205 _61bb47481908c67d4249a205 { get; set; }
            public _61bb474b1ab5304c3817a53a _61bb474b1ab5304c3817a53a { get; set; }
            public _61bb474dce7374453b45dfd2 _61bb474dce7374453b45dfd2 { get; set; }
            public _61bb474f8b8d2a79d012cd6e _61bb474f8b8d2a79d012cd6e { get; set; }
            public _61bb47516b70332c062ca7b9 _61bb47516b70332c062ca7b9 { get; set; }
            public _61bb475467f83663e155e26a _61bb475467f83663e155e26a { get; set; }
            public _61bb4756883b2c16a163870a _61bb4756883b2c16a163870a { get; set; }
            public _61bb47578d7cac1532300ccd _61bb47578d7cac1532300ccd { get; set; }
            public _61bfa784f4378605ca5598e1 _61bfa784f4378605ca5598e1 { get; set; }
        }

        public class _5422acb9af1c889c16000029
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _543be5664bdc2dd4348b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _543be5cb4bdc2deb348b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _543be5dd4bdc2deb348b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _543be5e94bdc2df1348b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _543be5f84bdc2dd4348b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _543be6564bdc2df4348b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _543be6674bdc2df1348b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5447a9cd4bdc2dbd208b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5447ac644bdc2d6c208b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5447b5cf4bdc2d65278b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5447b5e04bdc2d62278b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5447b5f14bdc2d61278b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5447b5fc4bdc2d87278b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5447b6094bdc2dc3278b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5447b6194bdc2d67278b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5447b6254bdc2dc3278b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5447bed64bdc2d97278b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5447bedf4bdc2d87278b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5447bee84bdc2dc3278b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5447e0e74bdc2d3c308b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5447e1d04bdc2dff2f8b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448ba0b4bdc2d02308b456c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448bc234bdc2d3c308b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448bd6b4bdc2dfc2f8b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448be9a4bdc2dfd2f8b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448bf274bdc2dfc2f8b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448c12b4bdc2d02308b456f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448c1d04bdc2dff2f8b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448e5284bdc2dcb718b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448e53e4bdc2d60728b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448e54d4bdc2dcc718b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448e5724bdc2ddf718b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448e8d04bdc2ddf718b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448e8d64bdc2dce718b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448eb774bdc2d0a728b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448ecbe4bdc2d60728b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448f39d4bdc2d0a728b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448f3a14bdc2d27728b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448f3a64bdc2d60728b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448f3ac4bdc2dce718b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448fe124bdc2da5018b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448fe394bdc2d0d028b456c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448fe7a4bdc2d6f028b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448fee04bdc2dbc018b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5448ff904bdc2d6f028b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5449016a4bdc2d6f028b456f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544909bb4bdc2d6f028b4577
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _54491bb74bdc2d09088b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _54491c4f4bdc2db1078b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544a11ac4bdc2d470e8b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544a378f4bdc2d30388b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544a37c44bdc2d25388b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544a38634bdc2d58388b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544a3a774bdc2d3a388b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544a5caa4bdc2d1a388b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544a5cde4bdc2d39388b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544fb25a4bdc2dfb738b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544fb3364bdc2d34748b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544fb37f4bdc2dee738b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544fb3f34bdc2d03748b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544fb45d4bdc2dee738b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544fb5454bdc2df8738b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544fb62a4bdc2dfb738b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _544fb6cc4bdc2d34748b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _54527a984bdc2d4e668b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _54527ac44bdc2d36668b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _545cdae64bdc2d39198b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _545cdb794bdc2d3a198b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5464e0404bdc2d2a708b4567
        {
            public string description { get; set; }
            public string name { get; set; }
        }

        public class _5464e0454bdc2d06708b4567
        {
            public string description { get; set; }
            public string name { get; set; }
        }

        public class _5485a8684bdc2da71d8b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _54cb50c76803fa8b248b4571
        {
            public string Description { get; set; }
            public string FirstName { get; set; }
            public string FullName { get; set; }
            public string Location { get; set; }
            public string Nickname { get; set; }
        }

        public class _54cb57776803fa99248b456e
        {
            public string Description { get; set; }
            public string FirstName { get; set; }
            public string FullName { get; set; }
            public string Location { get; set; }
            public string Nickname { get; set; }
        }

        public class _550aa4154bdc2dd8348b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _550aa4af4bdc2dd4348b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _550aa4bf4bdc2dd6348b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _550aa4cd4bdc2dd8348b456c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _550aa4dd4bdc2dc9348b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _550ad14d4bdc2dd5348b456c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _555ef6e44bdc2de9068b457e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _557596e64bdc2dc2118b4571
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _557ff21e4bdc2d89578b4586
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _557ffd194bdc2d28148b457f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5580169d4bdc2d9d138b4585
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55801eed4bdc2d89578b4588
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5580223e4bdc2d1c128b457f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _558022b54bdc2dac148b458d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55802d5f4bdc2dac148b458e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55802f3e4bdc2de7118b4584
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55802f4a4bdc2ddb688b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55802f5d4bdc2dac148b458f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _558032614bdc2de7118b4585
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818a104bdc2db9688b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818a304bdc2db5418b457d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818a594bdc2db9688b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818a604bdc2db5418b457e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818a684bdc2ddd698b456d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818a6f4bdc2db9688b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818ac54bdc2d5b648b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818acf4bdc2dde698b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818ad54bdc2ddc698b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818add4bdc2d5b648b456f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818ae44bdc2dde698b456c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818aeb4bdc2ddc698b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818af64bdc2d5b648b4570
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818afb4bdc2dde698b456d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818b014bdc2ddc698b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818b084bdc2d5b648b4571
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818b0e4bdc2dde698b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818b164bdc2ddc698b456c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818b1d4bdc2d5b648b4572
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55818b224bdc2dde698b456f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _559ba5b34bdc2d1f1a8b4582
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d355e64bdc2d962f8b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d35ee94bdc2d61338b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d3632e4bdc2d972f8b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d447bb4bdc2d892f8b456f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d448594bdc2d8c2f8b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d4491a4bdc2d882f8b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d449444bdc2d962f8b456d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d44fd14bdc2d962f8b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d459824bdc2d892f8b4573
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d45d3f4bdc2d972f8b456c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d45f484bdc2d972f8b456d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d480c04bdc2d1d4e8b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d481904bdc2d8c2f8b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d482194bdc2d1d4e8b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d4837c4bdc2d1d4e8b456c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d484b44bdc2d1d4e8b456d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d485804bdc2d8c2f8b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d485be4bdc2d962f8b456f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d4887d4bdc2d962f8b4570
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d48a634bdc2d8b2f8b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d48ebc4bdc2d8c2f8b456c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d4ae6c4bdc2d8b2f8b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d4af3a4bdc2d972f8b456f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d4b9964bdc2d1d4e8b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d5f46a4bdc2d1b198b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d614004bdc2d86028b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d6190f4bdc2d87028b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d720f24bdc2d88028b456d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55d7217a4bdc2d86028b456d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _55f2d3fd4bdc2d5f408b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _55f84c3c4bdc2d5f408b4576
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _560835c74bdc2dc8488b456f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _560836484bdc2d20478b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _560836b64bdc2d57468b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _560836fb4bdc2d773f8b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _560837154bdc2da74d8b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5608373c4bdc2dc8488b4570
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _560837544bdc2de22e8b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _560837824bdc2d57468b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5608379a4bdc2d26448b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _560838c94bdc2d77798b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56083a334bdc2dc8488b4571
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56083be64bdc2d20478b456f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56083cba4bdc2de22e8b456f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56083e1b4bdc2dc8488b4572
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56083eab4bdc2d26448b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _560d5e524bdc2d25448b4571
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _560d61e84bdc2da74d8b4571
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _560d657b4bdc2da74d8b4572
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _560d75f54bdc2da74d8b4573
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _560e620e4bdc2d724b8b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5644bd2b4bdc2d3b4c8b4572
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5645bc214bdc2d363b8b4571
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5645bcb74bdc2ded0b8b4578
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5645bcc04bdc2d363b8b4572
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5648a69d4bdc2ded0b8b457b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5648a7494bdc2d9d488b4583
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5648ac824bdc2ded0b8b457d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5648ae314bdc2d3d1c8b457f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5648b0744bdc2d363b8b4578
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5648b1504bdc2d9d488b4584
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5648b4534bdc2d3d1c8b4580
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649a2464bdc2d91118b45a8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649aa744bdc2ded0b8b457e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649ab884bdc2ded0b8b457f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649ad3f4bdc2df8348b4585
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649ade84bdc2d1b2b8b4587
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649ae4a4bdc2d1b2b8b4588
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649af094bdc2df8348b4586
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649af884bdc2d1b2b8b4589
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649b0544bdc2d1b2b8b458a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649b0fc4bdc2d17108b4588
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649b1c04bdc2d16268b457c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649b2314bdc2d79388b4576
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649be884bdc2d79388b4577
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649d9a14bdc2d79388b4580
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5649ed104bdc2d3d1c8b458b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _564ca99c4bdc2d16268b4589
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _564ca9df4bdc2d35148b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _564caa3d4bdc2d17108b458e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5656d7c34bdc2d9d198b4587
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5656eb674bdc2d35148b457c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _566162e44bdc2d3f298b4573
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5661632d4bdc2d903d8b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _566168634bdc2d144c8b456c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _566965d44bdc2d814c8b4571
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _566abbb64bdc2d144c8b457d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _566abbc34bdc2d92178b4576
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5671435f4bdc2d96058b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _567143bf4bdc2d1a0f8b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5672c92d4bdc2d180f8b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5672cb124bdc2d1a0f8b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5672cb304bdc2dc2088b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5672cb724bdc2dc2088b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5673de654bdc2d180f8b456d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56742c284bdc2d98058b456d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56742c2e4bdc2d95058b456d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56742c324bdc2d150f8b456d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _567583764bdc2d98058b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _567849dd4bdc2d150f8b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5696686a4bdc2da3298b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _569668774bdc2da2298b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56d59856d2720bd8418b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56d59948d2720bb7418b4582
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56d59d3ad2720bdb418b4577
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _56d5a1f7d2720bb3418b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56d5a2bbd2720bb8418b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56d5a407d2720bb3418b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56d5a661d2720bd8418b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56d5a77ed2720b90418b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56db0b3bd2720bb0678b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _56dee2bdd2720bc8328b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56deec93d2720bec348b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56deed6ed2720b4c698b4583
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56deee15d2720bee328b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56deeefcd2720bc8328b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56def37dd2720bec348b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56dfef82d2720bbd668b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _56dff026d2720bb8668b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _56dff061d2720bb5668b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _56dff0bed2720bb0668b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _56dff216d2720bbd668b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _56dff2ced2720bb4668b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _56dff338d2720bbd668b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _56dff3afd2720bba668b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _56dff421d2720b5f5a8b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _56dff4a2d2720bbd668b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _56dff4ecd2720b5f5a8b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _56e0598dd2720bb5668b45a6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56e05a6ed2720bd0748b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56e05b06d2720bb2668b4586
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56e335e4d2720b6c058b456d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56e33634d2720bd8058b456b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56e33680d2720be2748b4576
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56ea6fafd2720b844b8b4593
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56ea70acd2720b844b8b4594
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56ea7165d2720b6e518b4583
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56ea7293d2720b8d4b8b45ba
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56ea8180d2720bf2698b456a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56ea8222d2720b69698b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56ea8d2fd2720b7c698b4570
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56ea9461d2720b67698b456f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56eabcd4d2720b66698b4574
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56eabf3bd2720b75698b4569
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _56f40101d2720b2a4d8b45d6
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _5704e3c2d2720bac5b8b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _5704e47ed2720bb35b8b4568
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _5704e4dad2720bb55b8b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _5704e554d2720bac5b8b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _5704e5a4d2720bb45b8b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _5704e5fad2720bc05b8b4567
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _5704e64ad2720bb55b8b456e
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _570fd6c2d2720bc6458b457f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _570fd721d2720bc5458b4596
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _570fd79bd2720bc7458b4583
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5710c24ad2720bc3458b45a3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5714dbc024597771384a510d
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _5714dc342459777137212e0b
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _5714dc692459777137212e12
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _571659bb2459771fb2755a12
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _571a12c42459771f627b58a0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _571a26d524597720680fbe8a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _571a279b24597720b4066566
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _571a282c2459771fb2755a69
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _571a28e524597720b4066567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _571a29dc2459771fb2755a6a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57235b6f24597759bf5a30f1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _572b7adb24597762ae139821
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _572b7d8524597762b472f9d1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _572b7f1624597762ae139822
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _572b7fa124597762b472f9d2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _572b7fa524597762b747ce82
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5732ee6a24597719ae0c0281
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5733279d245977289b77ec24
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _573474f924597738002c6174
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5734758f24597738025ee253
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _573475fb24597737fb1379e1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _573476d324597737da2adc13
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _573476f124597737e04bf328
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5734770f24597738025ee254
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5734773724597737fd047c14
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5734779624597737e04bf329
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _573477e124597737dd42e191
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5734781f24597737e04bf32a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _573478bc24597738002c6175
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5734795124597738002c6176
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347b8b24597737dd42e192
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347baf24597738002c6178
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347c1124597737fb1379e3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347c2e24597744902c94a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347c5b245977448d35f6e1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347c77245977448d35f6e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347c93245977448d35f6e3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347ca924597744596b4e71
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347cd0245977445a2d6ff1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347d3d245977448f7b7f61
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347d5f245977448b40fa81
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347d692459774491567cf1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347d7224597744596b4e72
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347d8724597744596b4e76
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347d90245977448f7b7f65
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347d9c245977448b40fa85
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57347da92459774491567cf5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5735fdcd2459776445391d61
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5735ff5c245977640e39ba7e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _573601b42459776410737435
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _573602322459776445391df1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5736026a245977644601dc61
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _573603562459776430731618
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _573603c924597764442bd9cb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _573718ba2459775a75491131
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _573719762459775a626ccbc1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _573719df2459775a626ccbc2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _57371aab2459775a77142f22
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _57371b192459775a9f58a5e0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _57371e4124597760ff7b25f1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _57371eb62459776125652ac1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _57371f2b24597761224311f1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _57371f8d24597761006c6a81
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5737201124597760fc4431f1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5737207f24597760ff7b25f2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _573720e02459776143012541
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _57372140245977611f70ee91
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5737218f245977612125ba51
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _573722e82459776104581c21
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _573724b42459776125652ac2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5737250c2459776125652acc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5737256c2459776125652acd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _573725b0245977612125bae2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5737260b24597761224311f2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5737266524597761006c6a8c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _573726d824597765d96be361
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5737273924597765dd374461
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _573727c624597765cc785b5b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5737280e24597765cc785b5c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5737287724597765e1625ae2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _573728cc24597765cc785b5d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _573728f324597765e5728561
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5737292724597765e5728562
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372a7f24597766fe0de0c1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372ac324597767001bc261
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372b832459776701014e41
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372bad245977670b7cd242
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372bd3245977670b7cd243
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372c21245977670937c6c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372c56245977685e584582
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372c89245977685d4159b1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372d1b2459776862260581
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372d4c245977685a3da2a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372db0245977685d4159b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372deb245977685d4159b3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372e1924597768553071c1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372e4a24597768553071c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372e73245977685d4159b4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372e94245977685648d3e1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372ebf2459776862260582
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372ee1245977685d4159b5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372f2824597769a270a191
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372f5c24597769917c0131
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372f7d245977699b53e301
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57372fc52459776998772ca1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5737300424597769942d5a01
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5737330a2459776af32363a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5737339e2459776af261abeb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _573733c72459776b0b7b51b0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5739d41224597779c3645501
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57486e672459770abd687134
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _574d967124597745970e7c94
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _574dad8024597745964bf05c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _574db213245977459a2f3f5d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _574eb85c245977648157eec3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57505f6224597709a92585a9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _575062b524597720a31c09a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57513f07245977207e26a311
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57513f9324597720a7128161
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57513fcc24597720a31c09a6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5751435d24597720a27126d1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57514643245977207f2c2d09
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _575146b724597720a27126d5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5751487e245977207e26a315
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5751496424597720a27126da
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5751a25924597722c463c472
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5751a89d24597722aa0e8db0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5755356824597772cb798962
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5755383e24597772cb798966
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _576165642459773c7a400233
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _576167ab2459773cad038c43
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _576169e62459773c69055191
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57616a9e2459773c7a400234
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57616c112459773cce774d66
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57616ca52459773c69055192
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _576a581d2459771e7b1bc4f1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _576a5ed62459771e9c2096cb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _576a63cd2459771e796e0e11
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _576a7c512459771e796e0e17
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _576fd4ec2459777f0b518431
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _577d128124597739d65d0e56
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _577d141e24597739c5255e01
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _577e1c9d2459773cd707c525
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5780cda02459777b272ede61
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5780cf692459777de4559321
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5780cf722459777a5108b9a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5780cf7f2459777de4559322
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5780cf942459777df90dcb72
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5780cf9e2459777df90dcb73
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5780cfa52459777dfb276eb1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5780d0532459777a5108b9a2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5780d0652459777df90dcb74
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5780d07a2459777de4559324
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57838ad32459774a17445cd2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57838c962459774a1651ec63
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57838e1b2459774a256959b1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57838f0b2459774a256959b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57838f9f2459774a150289a0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _578395402459774a256959b5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _578395e82459774a0e553c7b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5783c43d2459774bbe137486
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57864a3d24597754843f8721
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57864a66245977548f04a81f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57864ada245977548638de91
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57864bb7245977548b3b66c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57864c322459775490116fbf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57864c8c245977548867e7f1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57864e4c24597754843f8723
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57864ee62459775490116fc1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _578f8778245977358849a9b5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _578f8782245977354405a1e3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _578f879c24597735401e6bc6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _578f87a3245977356274f2cb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _578f87ad245977356274f2cc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _578f87b7245977356274f2cd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _579204f224597773d619e051
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5795f317245977243854e041
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5798a2832459774b53341029
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _579b1eb1d53a0658a154fbe6
        {
            public string Name { get; set; }
        }

        public class _579b2068d53a0658a154fbe8
        {
            public string Name { get; set; }
        }

        public class _579dc571d53a0658a154fbec
        {
            public string Description { get; set; }
            public string FirstName { get; set; }
            public string FullName { get; set; }
            public string Location { get; set; }
            public string Nickname { get; set; }
        }

        public class _57a0dfb82459774d3078b56c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _57a0e5022459774d1673f889
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _57a3459f245977764a01f703
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57a349b2245977762b199ec7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57a39d5024597772b41c2a07
        {
            public string Name { get; set; }
        }

        public class _57a39d6c24597752f450ba71
        {
            public string Name { get; set; }
        }

        public class _57a39d75245977598b14f3a3
        {
            public string Name { get; set; }
        }

        public class _57a39d7c24597752f8541718
        {
            public string Name { get; set; }
        }

        public class _57a39d8324597752f63fac43
        {
            public string Name { get; set; }
        }

        public class _57a39d8c24597752f575f70f
        {
            public string Name { get; set; }
        }

        public class _57a39d9d245977598b14f3b0
        {
            public string Name { get; set; }
        }

        public class _57a9b9ce2459770ee926038d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57ac965c24597706be5f975c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57aca93d2459771f2c7e26db
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57acb6222459771ec34b5cb0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57ade1442459771557167e15
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57adff4f24597737f373b6e6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57ae0171245977343c27bfcf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57af48872459771f0b2ebf11
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57bef4c42459772e8d35a53b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57c44b372459772d2b39b8ce
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57c44dd02459772d2e0ae249
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57c44e7b2459772d28133248
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57c44f4f2459772d2c627113
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57c44fa82459772d2d75e415
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57c450252459772d28133253
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57c55efc2459772d2c6271e7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57c55f092459772d291a8463
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57c55f112459772d28133310
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57c55f172459772d27602381
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57c5ac0824597754771e88a9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57c69dd424597774c03b7bbc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57c9a89124597704ee6faec1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57cd379a24597778e7682ecf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57cff947245977638e6f2a19
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57cffb66245977632f391a99
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57cffcd624597763133760c5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57cffcdd24597763f5110006
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57cffce524597763b31685d8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57cffd8224597763b03fc609
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57cffddc24597763133760c6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57cffe0024597763b03fc60b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57cffe20245977632f391a9d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57d14d2524597714373db789
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57d14e1724597714010c3f4b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57d1519e24597714373db79d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57d152ec245977144076ccdf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57d17c5e2459775a5c57d17d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57d17e212459775a1179a0f5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57da93632459771cb65bf83f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57dbb57e2459774673234890
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57dc2fa62459775949412633
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57dc324a24597759501edc20
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57dc32dc245977596d4ef3d3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57dc334d245977597164366f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57dc347d245977596754e7a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57e26ea924597715ca604a09
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57e26fc7245977162a14b800
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57e3dba62459770f0c32322b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57ee59b42459771c7b045da5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57f3a5ae2459772b0e0bf19e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57f3bde7245977396961682f
        {
            public string Name { get; set; }
        }

        public class _57f3c6bd24597738e730fa2f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57f3c7e024597738ea4ba286
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57f3c8cc2459773ec4480328
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57f4c844245977379d5c14d1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57fb59c2766bef92daf44bd4
        {
            public string Name { get; set; }
        }

        public class _57fb5a6d766bef92daf44bd7
        {
            public string Name { get; set; }
        }

        public class _57fd23e32459772d0805bcf1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57ffa9f4245977728561e844
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57ffaea724597779f52b3a4d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57ffb0062459777a045af529
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _57ffb0e42459777d047111c5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5803a58524597710ca36fcb2
        {
            public string description { get; set; }
            public string name { get; set; }
        }

        public class _5805f617245977100b2c1f41
        {
            public string description { get; set; }
            public string name { get; set; }
        }

        public class _5807be8924597742c603fa19
        {
            public string description { get; set; }
            public string name { get; set; }
        }

        public class _5807bfe124597742a92e0a4c
        {
            public string description { get; set; }
            public string name { get; set; }
        }

        public class _5807c3f124597746bf2db2ce
        {
            public string description { get; set; }
            public string name { get; set; }
        }

        public class _5811ce572459770cba1a34ea
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5811ce662459770f6f490f32
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5811ce772459770e9e5f9532
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5827272a24597748c74bdeea
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58272b392459774b4c7b3ccd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58272b842459774abc128d50
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58272d7f2459774f6311ddfd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58330581ace78e27b8b10cee
        {
            public string Description { get; set; }
            public string FirstName { get; set; }
            public string FullName { get; set; }
            public string Location { get; set; }
            public string Nickname { get; set; }
        }

        public class _583990e32459771419544dd2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5839a40f24597726f856b511
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5839a7742459773cf9693481
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5841474424597759ba49be91
        {
            public string Name { get; set; }
        }

        public class _584147732459775a2b6d9f12
        {
            public string Name { get; set; }
        }

        public class _584147982459775a6c55e931
        {
            public string Name { get; set; }
        }

        public class _584147ed2459775a77263501
        {
            public string Name { get; set; }
        }

        public class _5841482e2459775a050cdda9
        {
            public string Name { get; set; }
        }

        public class _5841488a24597759eb357a3f
        {
            public string Name { get; set; }
        }

        public class _584148a524597759eb357a44
        {
            public string Name { get; set; }
        }

        public class _584148f2245977598f1ad387
        {
            public string Name { get; set; }
        }

        public class _58414907245977598f1ad38d
        {
            public string Name { get; set; }
        }

        public class _584149242459775a7726350a
        {
            public string Name { get; set; }
        }

        public class _584149452459775992479702
        {
            public string Name { get; set; }
        }

        public class _58414967245977598f1ad391
        {
            public string Name { get; set; }
        }

        public class _5841499024597759f825ff3e
        {
            public string Name { get; set; }
        }

        public class _584149ad2459775a7726350e
        {
            public string Name { get; set; }
        }

        public class _584149c42459775a77263510
        {
            public string Name { get; set; }
        }

        public class _584149ea2459775a6c55e940
        {
            public string Name { get; set; }
        }

        public class _58414a052459775a2b6d9f1e
        {
            public string Name { get; set; }
        }

        public class _58414a16245977599247970a
        {
            public string Name { get; set; }
        }

        public class _58414a2724597759b344da4d
        {
            public string Name { get; set; }
        }

        public class _58414a3f2459775a77263531
        {
            public string Name { get; set; }
        }

        public class _58491f3324597764bc48fa02
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _584924ec24597768f12ae244
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _584984812459776a704a82a6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5857a8b324597729ab0a0e7d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5857a8bc2459772bad15db29
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _587de4282459771bca0ec90b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _587de5ba2459771c0f1e8a58
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _587df3a12459772c28142567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _587df583245977373c4f1129
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _587e02ff24597743df3deaeb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _587e0531245977466077a0f7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _587e08ee245977446b4410cf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _588200af24597742fa221dfb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _588200c224597743990da9ed
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _588200cf2459774414733d55
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58820d1224597753c90aeb13
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5882163224597757561aa920
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5882163824597757561aa922
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5882163e24597758206fee8c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _588226d124597767ad33f787
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _588226dd24597767ad33f789
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _588226e62459776e3e094af7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _588226ef24597767af46e39c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58864a4f2459770fcc257101
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5887431f2459777e1612938f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _588892092459774ac91d4b11
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5888945a2459774bf43ba385
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5888956924597752983e182d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5888961624597754281f93f3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5888976c24597754281f93f5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5888988e24597752fe43a6fa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5888996c24597754281f9419
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58889c7324597754281f9439
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58889d0c2459775bc215d981
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _588b56d02459771481110ae2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58948c8e86f77409493f7266
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58949dea86f77409483e16a8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58949edd86f77409483e16a9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58949fac86f77409483e16aa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5894a05586f774094708ef75
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5894a13e86f7742405482982
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5894a2c386f77427140b8342
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5894a42086f77426d2590762
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5894a51286f77426d13baf02
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5894a5b586f77426d2590767
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5894a73486f77426d259076c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5894a81786f77427140b8347
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58a56f8d86f774651579314c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58a5c12e86f7745d585a2b9e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58ac1bf086f77420ed183f9f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58aeaaa886f7744fc1560f81
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58aeac1b86f77457c419f475
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58c157be86f77403c74b2bb6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58c157c886f774032749fb06
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58d2664f86f7747fec5834f6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58d268fc86f774111273f8c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58d2912286f7744e27117493
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58d2946386f774496974c37e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58d2946c86f7744e271174b5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58d2947686f774485c6a1ee5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58d2947e86f77447aa070d53
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58d399e486f77442e0016fe7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58d39b0386f77443380bf13c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58d39d3d86f77445bb794ae7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58d3db5386f77426186285a0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _58dd3ad986f77403051cba8f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _58dffc5d86f77407c744a847
        {
            public string Name { get; set; }
        }

        public class _58dffca786f774083a256ab1
        {
            public string Name { get; set; }
        }

        public class _58dffce486f77409f40f8162
        {
            public string Name { get; set; }
        }

        public class _58dffd3486f77409f40f81d6
        {
            public string Name { get; set; }
        }

        public class _58dffd4586f77408a27629b2
        {
            public string Name { get; set; }
        }

        public class _5900b89686f7744e704a8747
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5909d24f86f77466f56e6855
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5909d36d86f774660f0bb900
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5909d45286f77465a8136dc6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5909d4c186f7746ad34e805a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5909d50c86f774659e6aaebe
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5909d5ef86f77467974efbd8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5909d76c86f77471e53d2adf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5909d7cf86f77470ee57d75a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5909d89086f77472591234a0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5909e4b686f7747f5b744fa4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5909e99886f7740c983b9984
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590a358486f77429692b2790
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590a373286f774287540368b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590a386e86f77429692b27ab
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590a391c86f774385a33c404
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590a3b0486f7743954552bdb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590a3c0a86f774385a33c450
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590a3cd386f77436f20848cb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590a3d9c86f774385926e510
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590a3efd86f77437d351a25b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c2b4386f77425357b6123
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c2c9c86f774245b1f03f2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c2d8786f774245b1f03f3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c2e1186f77425357b6124
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c311186f77424d1667482
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c31c586f774245e3141b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c346786f77423e50ed342
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c35a486f774273531c822
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c37d286f77443be3d7827
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c392f86f77444754deb29
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c595c86f7747884343ad7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c5a7286f7747884343aea
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c5bbd86f774785762df04
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c5c9f86f77477c91c36e7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c5d4b86f774784e1b9c45
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c5f0d86f77413997acfab
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c60fc86f77412b13fddcf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c621186f774138d11ea29
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c62a386f77412b0130255
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c639286f774151567fa95
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c645c86f77412b01304d9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c651286f7741e566b6461
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c657e86f77412b013051d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c661e86f7741e566b646a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c678286f77426c9660122
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590c695186f7741e566b64a2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590dde5786f77405e71908b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590de71386f774347051a052
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590de7e986f7741b096e5f32
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _590de92486f77423d9312a33
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5910922b86f7747d96753483
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _591092ef86f7747bb8703422
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public int ShortName { get; set; }
        }

        public class _591093bb86f7747caa7bb2ee
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5913611c86f77479e0084092
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5913651986f774432f15d132
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59136a4486f774447a1ed172
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59136e1e86f774432f15d133
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59136f6f86f774447a1ed173
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _591382d986f774465a6413a7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _591383f186f7744a4c5edcf3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5913877a86f774432f15d444
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5913915886f774123603c392
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59139c2186f77411564f8e42
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5914578086f774123569ffa4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59148c8a86f774197930e983
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59148f8286f7741b951ea113
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5914944186f774189e5e76c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _591ae8f986f77406f854be45
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _591aef7986f774139d495f03
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _591af10186f774139d495f0e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _591af28e86f77414a27a9e1d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _591afe0186f77431bd616a11
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _591c4e1186f77410354b316e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _591c4efa86f7741030027726
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _591ee00d86f774592f7b841e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5926bb2186f7744b1c6c6e60
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5926c0df86f77462f647f764
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5926c32286f774616e42de99
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5926c36d86f77467a92a8629
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5926c3b286f774640d189b6b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5926d2be86f774134d668e4e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5926d33d86f77410de68ebc0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5926d3c686f77410de68ebc8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5926d40686f7740f152b6b7e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5926dad986f7741f82604363
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5926e16e86f7742f5a0f7ecb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5926f2e086f7745aae644231
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5926f34786f77469195bfe92
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5929a2a086f7744f4b234d43
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _592c2d1a86f7746dbe2af32a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5935c25fb3acc3127c3d8cd9
        {
            public string Description { get; set; }
            public string FirstName { get; set; }
            public string FullName { get; set; }
            public string Location { get; set; }
            public string Nickname { get; set; }
        }

        public class _5936d90786f7742b1420ba5b
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5936da9e86f7742d65037edf
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5937ee6486f77408994ba448
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5937ef2b86f77408a47244b3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5937fc6786f7742cab753590
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5937fd0086f7742bf33fc198
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5938144586f77473c2087145
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5938188786f77474f723e87f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public int ShortName { get; set; }
        }

        public class _5938504186f7740991483f30
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _593858c486f774253a24cb52
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5938603e86f77435642354f4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59387a4986f77401cc236e62
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59387ac686f77401442ddd61
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5938878586f7741b797c562f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public int ShortName { get; set; }
        }

        public class _5938994586f774523a425196
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _593962ca86f774068014d9af
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _593965cf86f774087a77e1b6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public int ShortName { get; set; }
        }

        public class _5939a00786f7742fe8132936
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5939e5a786f77461f11c0098
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public int ShortName { get; set; }
        }

        public class _5939e9b286f77462a709572c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _593a87af86f774122f54a951
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _593aa4be86f77457f56379f8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _593d1fa786f7746da62d61ac
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _593d489686f7745c6255d58a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _593d490386f7745ee97a1555
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _593d493f86f7745e6b2ceb22
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59411aa786f7747aeb37f9a5
        {
            public string Name { get; set; }
        }

        public class _59411abb86f77478f702b5d2
        {
            public string Name { get; set; }
        }

        public class _59430b9b86f77403c27945fd
        {
            public string Name { get; set; }
        }

        public class _59430beb86f77403c2794609
        {
            public string Name { get; set; }
        }

        public class _59430c2086f77404814536fc
        {
            public string Name { get; set; }
        }

        public class _5943d9c186f7745a13413ac9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5943ee5a86f77413872d25ec
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5943eeeb86f77412d6384f6b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5947c73886f7747701588af5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5947db3f86f77447880cf76f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5947e98b86f774778f1448bc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5947eab886f77475961d96c5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5947f92f86f77427344a76b1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5947fa2486f77425b47c1a9b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _595cf16b86f77427440c32e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _595cfa8b86f77427437e845b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5963866286f7747bf429b572
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5963866b86f7747bfa1c4462
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59674cd986f7744ab26e32f2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59674eb386f774539f14813a
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5967530a86f77462ba22226b
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59675d6c86f7740a842fc482
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59675ea386f77414b32bded2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _596760e186f7741e11214d58
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5967725e86f774601a446662
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5967733e86f774602332fc84
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59689ee586f7740d1570bbd5
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59689fbd86f7740d137ebfc4
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5968eb3186f7741dde183a4d
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5969f90786f77420d2328015
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5969f9e986f7741dde183a50
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _596a0e1686f7741ddf17dbee
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _596a101f86f7741ddb481582
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _596a1e6c86f7741ddc2d3206
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _596a204686f774576d4c95de
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _596a218586f77420d232807c
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _596b36c586f77450d6045ad2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _596b43fb86f77457ca186186
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _596b455186f77457cb50eccb
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5979ed3886f77431307dc512
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5979eee086f774311955e614
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5979f8bb86f7743ec214c7a6
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5979f9ba86f7740f6c3fe9f2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _597a0b2986f77426d66c0633
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _597a0e5786f77426d66c0636
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _597a0f5686f774273b74f676
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _597a160786f77477531d39d2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _597a171586f77405ba6887d3
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5991b51486f77447b112d44f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _599319c986f7740dca3070a6
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _5996f6cb86f774678763a6ca
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5996f6d686f77467977ba6cc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5996f6fc86f7745e585b4de3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59984ab886f7743e98271174
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5998517986f7746017232f7e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _599851db86f77467372f0a18
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5998529a86f774647f44f421
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5998597786f77414ea6da093
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5998598e86f7740b3f498a86
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59985a6c86f77414ec448d17
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59985a8086f77414ec448d1a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _599860ac86f77436b225ed1a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _599860e986f7743bb57573a6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59b81f7386f77421ac688a0a
        {
            public string Name { get; set; }
        }

        public class _59bfc5c886f7743bf6794e62
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59bfe68886f7746004266202
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59bffbb386f77435b379b9c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59bffc1f86f77435b128b872
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59c0ea2130c28d455c92e892
        {
            public string Description { get; set; }
            public string FirstName { get; set; }
            public string FullName { get; set; }
            public string Location { get; set; }
            public string Nickname { get; set; }
        }

        public class _59c0ec5b86f77435b128bfca
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59c124d686f774189b3c843f
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59c1383d86f774290a37e0ca
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59c50a9e86f7745fef66f4ff
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59c50c8886f7745fed3193bf
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59c512ad86f7741f0d09de9b
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59c63b4486f7747afb151c1c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59c6633186f7740cf0493bb9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59c9392986f7742f6923add2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59c93e8e86f7742a406989c4
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59ca1a6286f774509a270942
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59ca264786f77445a80ed044
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59ca29fb86f77445ab465c87
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59ca2eb686f77445a80ed049
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59ccd11386f77428f24a488f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59ccfdba86f7747f2109a587
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59d36a0086f7747e673f3946
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59d6088586f774275f37482f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59d625f086f774661516605d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59d6272486f77466146386ff
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59d64ec286f774171d1e0a42
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59d64f2f86f77417193ef8b3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59d64fc686f774171b243fe2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59d6507c86f7741b846413a2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59d650cf86f7741b846413a4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59d6514b86f774171a068a08
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59d790f486f77403cb06aec6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59db3a1d86f77429e05b4e92
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59db3acc86f7742a2c4ab912
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59db3b0886f77429d72fb895
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59db794186f77448bc595262
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59db7e1086f77448be30ddf3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59db7eed86f77461f8380365
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59dcdbb386f77417b03f350d
        {
            public string Name { get; set; }
        }

        public class _59e0bdb186f774156f04ce82
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e0be5d86f7742d48765bd2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e0bed186f774156f04ce84
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e0d99486f7744a32234762
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59e3556c86f7741776641ac2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e3577886f774176a362503
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e358a886f7741776641ac3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e3596386f774176c10a2a2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e35abd86f7741778269d82
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e35cbb86f7741778269d83
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e35de086f7741778269d84
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e35ef086f7741777737012
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e3606886f77417674759a5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e361e886f774176c10a2a5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e3639286f7741777737013
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e3647686f774176a362507
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e3658a86f7741776641ac4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e366c186f7741778269d85
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e36c6f86f774176c10a2a7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e4cf5286f7741778269d8a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59e4d24686f7741776641ac7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59e4d3d286f774176a36250a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59e5d83b86f7745aed03d262
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e5f5a486f7746c530b3ce2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e6152586f77473dc057aa1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e61eb386f77440d64f5daf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e6227d86f77440d64f5dc2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e6284f86f77440d569536f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e62cc886f77440d40b52a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e6318286f77444dd62c4cc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e6449086f7746c9f75e822
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e649f986f77411d949b246
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e6542b86f77411dc52a77a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59e655cb86f77411dc52a77b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59e6658b86f77411d949b250
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59e6687d86f77411d949b251
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e68f6f86f7746c9f75e846
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59e6906286f7746c9f75e847
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59e690b686f7746c9f75e848
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59e6918f86f7746c9f75e849
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59e6920f86f77411d82aa167
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59e6927d86f77411da468256
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59e7635f86f7742cbf2c1095
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e763f286f7742ee57895da
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e7643b86f7742cbf2c109a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e7708286f7742cbd762753
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e770b986f7742cbd762754
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e770f986f7742cbe3164ef
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e7711e86f7746cae05fbe1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e7715586f7742ee5789605
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e77a2386f7742ee578960a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _59e8977386f77415a553c453
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e898ee86f77427614bd225
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e89d0986f77427600d226e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e8a00d86f7742ad93b569c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59e8d2ab86f77407f03fc9c2
        {
            public object Name { get; set; }
        }

        public class _59e8d2b386f77445830dd299
        {
            public string Name { get; set; }
        }

        public class _59eb7ebe86f7740b373438ce
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59ecc28286f7746d7a68aa8c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59ecc3dd86f7746dc827481c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59ef13ca86f77445fd0e2483
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59ef247086f77439967a900a
        {
            public object Name { get; set; }
        }

        public class _59ef24b986f77439987b8762
        {
            public object Name { get; set; }
        }

        public class _59f32bb586f774757e1e8442
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59f32c3b86f77472a31742f0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59f8a37386f7747af3328f06
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59f98b4986f7746f546d2cef
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59f99a7d86f7745b134aa97b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59f9cabd86f7743a10721f46
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59f9d81586f7744c7506ee62
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59f9da6786f774714230d751
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _59faf7ca86f7740dbe19f6c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59faf98186f774067b6be103
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59fafb5d86f774067a6f2084
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59fafc5086f7740dbe19f6c3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59fafc9386f774067d462453
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59fafd4b86f7745ca07e1232
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59faff1d86f7746c51718c9c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59fb016586f7746d0d4b423a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59fb023c86f7746d0d4b423c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59fb042886f7746c5005a7b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59fb137a86f7740adb646af1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59fb257e86f7742981561852
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59fb375986f7741b681b81a6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59fc48e086f77463b1118392
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59fc81d786f774390775787e
        {
            public string Description { get; set; }
            public string Name { get; set; }
        }

        public class _59ff346386f77477562ff5e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _59ff3b6a86f77477562ff5ed
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0060fc86f7745793204432
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0071d486f77404e23a12b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a01ad4786f77450561fda02
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a01c29586f77474660c694c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a03153686f77442d90e2171
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a03173786f77451cb427172
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a0327ba86f77456b9154236
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a03296886f774569778596a
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a0448bc86f774736f14efa8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0449d586f77474e66227b7
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a0abb6e1526d8000a025282
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0c27731526d80618476ac4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0c59791526d8dba737bba7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0d63621526d8dba31fe3bf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0d716f1526d8000d26b1e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0dc45586f7742f6b0b73e3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0dc95c86f77452440fc675
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0ea64786f7741707720468
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0ea69f86f7741cd5406619
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0ea79b86f7741d4a35298e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0eb38b86f774153b320eb0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0eb6ac86f7743124037a28
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0eb980fcdbcb001a3b00a6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0ec13bfcdbcb00165aa685
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0ec6d286f7742c0b518fb5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0ec70e86f7742c0b518fba
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0ed824fcdbcb0176308b0d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0ee30786f774023b6ee08f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0ee34586f774023b6ee092
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0ee37f86f774023657a86f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0ee4b586f7743698200d22
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0ee62286f774369454a7ac
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0ee72c86f77436955d3435
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0ee76686f7743698200d5c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0eeb1a86f774688b70aa5c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0eeb8e86f77461257ed71a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0eebed86f77461230ddb3d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0eec9686f77402ac5c39f2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0eecf686f7740350630097
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0eed4386f77405112912aa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0eedb386f77403506300be
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0eee1486f77402aa773226
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0eff2986f7741fd654e684
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0f006986f7741ffd2fe484
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0f045e86f7745b0f0d0e42
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0f068686f7745b0d4ea242
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0f075686f7745bcc42ee12
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0f08bc86f77478f33b84c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0f096dfcdbcb0176308b15
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a0f0f5886f7741c4e32a472
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a13df5286f774032f5454a0
        {
            public string Name { get; set; }
        }

        public class _5a13ee1986f774794d4c14cd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a13eebd86f7746fd639aa93
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a13ef0686f7746e5a411744
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a13ef7e86f7741290491063
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a13f24186f77410e57c5626
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a13f35286f77413ef1436b0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a13f46386f7741dd7384b04
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a144bdb86f7741d374bbde0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a144dfd86f77445cb5a0982
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a1452ee86f7746f33111763
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a145d4786f7744cbb6f4a12
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a145d7b86f7744cbb6f4a13
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a145ebb86f77458f1796f05
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a154d5cfcdbcb001a3b00da
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a16b672fcdbcb001912fa83
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a16b7e1fcdbcb00165aa6c9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a16b8a9fcdbcb00165aa6ca
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a16b93dfcdbcbcae6687261
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a16b9fffcdbcb0176308b34
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a16ba61fcdbcb098008728a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a16badafcdbcb001865f72d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a16bb52fcdbcb001a3b00dc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a17f98cfcdbcb0980087290
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a17fb03fcdbcbcae668728f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a17fb9dfcdbcbcae6687291
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a17fc70fcdbcb0176308b3d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a1eaa87fcdbcb001865f75e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a1eacb3fcdbcb09800872be
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a1ead28fcdbcb001912fa9f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a269f97c4a282000b151807
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5a26abfac4a28232980eabff
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5a26ac06c4a282000c5a90a8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5a26ac0ec4a28200741e1e18
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5a27b281c4a28200741e1e52
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a27b3d0c4a282000d721ec1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a27b6bec4a282000e496f78
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a27b75b86f7742e97191958
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27b7a786f774579c3eb376
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27b7d686f77460d847e6a6
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27b80086f774429a5d7e20
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27b87686f77460de0252a8
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27b9de86f77464e5044585
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27ba1c86f77461ea5a3c56
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27ba9586f7741b543d8e85
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27bad7c4a282000b15184b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a27bafb86f7741c73584017
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27bb1e86f7741f27621b7e
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27bb3d86f77411ea361a21
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27bb5986f7741dfb660900
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27bb8386f7741c770d2d0a
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27bbf886f774333a418eeb
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27bc1586f7741f6d40fa2f
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27bc3686f7741c73584026
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27bc6986f7741c7358402b
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27bc8586f7741b543d8ea4
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27c99a86f7747d2c6bdd8e
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a27d2af86f7744e1115b323
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a29276886f77435ed1b117c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a29284f86f77463ef3db363
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a29357286f77409c705e025
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a294d7c86f7740651337cf9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a294d8486f774068638cd93
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a2a57cfc4a2826c6e06d44a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a325c3686f7744273716c5b
        {
            public object Name { get; set; }
        }

        public class _5a327f4a86f774766866140b
        {
            public object Name { get; set; }
        }

        public class _5a327f6386f77479010da870
        {
            public string Name { get; set; }
        }

        public class _5a327f7286f7747668661419
        {
            public string Name { get; set; }
        }

        public class _5a327f7c86f77475187e509a
        {
            public string Name { get; set; }
        }

        public class _5a327f9086f77475187e50a9
        {
            public string Name { get; set; }
        }

        public class _5a32808386f774764a3226d9
        {
            public string Name { get; set; }
        }

        public class _5a329052c4a28200741e22d3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a32a064c4a28200741e22de
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a32aa0cc4a28232996e405f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a32aa8bc4a2826c6e06d737
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a339805c4a2826c6e06d73d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a33a8ebc4a282000c5a950d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a33b2c9c4a282000c5a9511
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a33b652c4a28232996e407c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a33bab6c4a28200741e22f8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a33ca0fc4a282000d72292f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a33cae9c4a28232980eb086
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a33e75ac4a2826c6e06d759
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a34f7f1c4a2826c6e06d75d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a34fae7c4a2826c6e06d760
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a34fbadc4a28200741e230a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a34fd2bc4a282329a73b4c5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a34fe59c4a282000b1521a2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a3501acc4a282000d72293a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a351711c4a282000b1521a4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a367e5dc4a282000e49738f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a37ca54c4a282000d72296a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a37cb10c4a282329a73b4e7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a38e6bac4a2826c6e06d79b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a38ebd9c4a282000d722a5b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5a38ed75c4a28232996e40c6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a38ee51c4a282000c5a955c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a38eecdc4a282329a73b512
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a38ef1fc4a282000b1521f6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a398ab9c4a282000c5a9842
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a398b75c4a282000a51a266
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a3a859786f7747e2305e8bf
        {
            public string Name { get; set; }
        }

        public class _5a3a85af86f774745637d46c
        {
            public string Name { get; set; }
        }

        public class _5a3b898486f77467720a2f29
        {
            public string Name { get; set; }
        }

        public class _5a3c16fe86f77452b62de32a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5a43943586f77416ad2f06e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a43957686f7742a2c2f11b0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a43a85186f7746c914b947a
        {
            public string Name { get; set; }
        }

        public class _5a43a86d86f7746c9d7395e8
        {
            public string Name { get; set; }
        }

        public class _5a5642ce86f77445c63c3419
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a5f1ce64f39f90b401987bc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a6086ea4f39f99cd479502f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5a608bf24f39f98ffc77720e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5a6860d886f77411cd3a9e47
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public int ShortName { get; set; }
        }

        public class _5a68661a86f774500f48afb0
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a68663e86f774501078f78a
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a68665c86f774255929b4c7
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a68667486f7742607157d28
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a68669a86f774255929b4d4
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5a687e7886f7740c4a5133fb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a69a2ed8dc32e000d46d1f1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a6b585a8dc32e5a9c28b4f1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a6b592c8dc32e00094b97bf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a6b59a08dc32e000b452fb7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a6b5b8a8dc32e001207faf3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a6b5e468dc32e001207faf5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a6b5ed88dc32e000c52ec86
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a6b5f868dc32e000a311389
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a6b60158dc32e000a31138b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a6f58f68dc32e000a311390
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a6f5d528dc32e00094b97d9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a6f5e048dc32e00094b97da
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a6f5f078dc32e00094b97dd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a702d198dc32e000b452fc3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7033908dc32e000a311392
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a70366c8dc32e001207fb06
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7037338dc32e000d46d257
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a705e128dc32e000d46d258
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a718b548dc32e000d46d262
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a718da68dc32e000d46d264
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a718f958dc32e00094b97e7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a71e0048dc32e000c52ecc8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a71e0fb8dc32e00094b97f2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a71e1868dc32e00094b97f3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a71e22f8dc32e00094b97f4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a71e4f48dc32e001207fb26
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7828548dc32e5a9c28b516
        {
            public string Description { get; set; }
            public string FoldedSlot { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a787ebcc5856700142fdd98
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a787f25c5856700186c4ab9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a787f7ac5856700177af660
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a787fadc5856700155a6ca1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a787fdfc5856700142fdd9a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a788031c585673f2b5c1c79
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a788068c5856700137e4c8f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a788089c5856700142fdd9c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7880d0c5856700142fdd9d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a78813bc5856700186c4abe
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a788169c5856700142fdd9e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7882dcc5856700177af662
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a78830bc5856700137e4c90
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a78832ec5856700155a6ca3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a789261c5856700186c65d3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7893c1c585673f2b5c374d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a78948ec5856700177b1124
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7ad0c451dfba0013379712
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7ad1fb51dfba0013379715
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7ad2e851dfba0016153692
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7ad4af51dfba0013379717
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7ad55551dfba0015068f42
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7ad74e51dfba0015068f45
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7ae0c351dfba0017554310
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7afa25e899ef00135e31b0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7b32a2e899ef00135e345a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7b483fe899ef0016170d15
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7b4900e899ef197b331a2a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7b4960e899ef197b331a2d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7c147ce899ef00150bd8b8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7c2eca46aef81a7ca2145d
        {
            public string Description { get; set; }
            public string FirstName { get; set; }
            public string FullName { get; set; }
            public string Location { get; set; }
            public string Nickname { get; set; }
        }

        public class _5a7c4850e899ef00150be885
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7c74b3e899ef0014332c29
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7d90eb159bd400165484f1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7d9104159bd400134c8c21
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7d9122159bd4001438dbf4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7d912f159bd400165484f3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a7dbfc1159bd40016548fde
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a800961159bd4315e3a1657
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a8036fb86f77407252ddc02
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a80a29286f7742b25692012
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a88acfb86f77457fd2c0d8f
        {
            public string Name { get; set; }
        }

        public class _5a88ad7b86f77479aa7226af
        {
            public string Name { get; set; }
        }

        public class _5a88ae4a86f77457fd2c0dae
        {
            public string Name { get; set; }
        }

        public class _5a88aed086f77476cd391963
        {
            public string Name { get; set; }
        }

        public class _5a88af5086f77411a871682c
        {
            public string Name { get; set; }
        }

        public class _5a88afdc86f7746de12fcc20
        {
            public string Name { get; set; }
        }

        public class _5a88b06b86f7746de12fcc2e
        {
            public string Name { get; set; }
        }

        public class _5a88b0f686f77416370eca3e
        {
            public string Name { get; set; }
        }

        public class _5a88b1f686f774159949926e
        {
            public string Name { get; set; }
        }

        public class _5a8ae21486f774377b73cf5d
        {
            public string Name { get; set; }
        }

        public class _5a8ae36686f774377d6ce226
        {
            public string Name { get; set; }
        }

        public class _5a8ae43686f774377b73cfb3
        {
            public string Name { get; set; }
        }

        public class _5a8ae54786f7743b5e013ba0
        {
            public string Name { get; set; }
        }

        public class _5a8ae65f86f774377a23ed55
        {
            public string Name { get; set; }
        }

        public class _5a8ae73886f7747b2e6e1416
        {
            public string Name { get; set; }
        }

        public class _5a8c436686f7740f394d10b5
        {
            public string Name { get; set; }
        }

        public class _5a9548c9159bd400133e97b3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a957c3fa2750c00137fa5f7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a966ec8a2750c00171b3f36
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a966f51a2750c00156aacf6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a9685b1a2750c0032157104
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a9d56c8a2750c0032157146
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a9d6d00a2750c5c985b5305
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a9d6d13a2750c00164f6b03
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a9d6d21a2750c00137fa649
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a9d6d34a2750c00141e07da
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a9e81fba2750c00164f6b11
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a9ea27ca2750c00137fa672
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a9eb32da2750c00171b3f9c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a9fb739a2750c003215717f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a9fbacda2750c00141e080f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a9fbb74a2750c0032157181
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a9fbb84a2750c00137fa685
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5a9fc7e6a2750c0032157184
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa2a7e8e5b5b00016327c16
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa2b87de5b5b00016327c25
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa2b89be5b5b0001569311f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa2b8d7e5b5b00014028f4a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa2b923e5b5b000137b7589
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa2b986e5b5b00014028f4c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa2b9aee5b5b00015693121
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa2b9ede5b5b000137b758b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa2ba19e5b5b00014028f4e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa2ba46e5b5b000137b758d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa2ba71e5b5b000137b758f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa66a9be5b5b0214e506e89
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa66be6e5b5b0214e506e97
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa66c72e5b5b00016327c93
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa7cfc0e5b5b00015693143
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa7d03ae5b5b00016327db5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa7d193e5b5b000171d063f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa7e276e5b5b000171d0647
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa7e373e5b5b000137b76f0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa7e3abe5b5b000171d064d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa7e454e5b5b0214e506fa2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aa7e4a4e5b5b000137b76f2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aaa4194e5b5b055d06310a5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aaa5dfee5b5b000140293d3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aaa5e60e5b5b000140293d6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aaf8a0be5b5b00015693243
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aaf8e43e5b5b00015693246
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aaf9d53e5b5b00015042a52
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aafa1c2e5b5b00015042a56
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aafa49ae5b5b00015042a58
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aafa857e5b5b00018480968
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aafbcd986f7745e590fff23
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aafbde786f774389d0cbc0f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab24ef9e5b5b00fe93c9209
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab372a310e891001717f0d8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab3afb2d8ce87001660304d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab626e4d8ce87272e4c6e43
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab8dab586f77441cd04f2a2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab8dced86f774646209ec87
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab8e4ed86f7742d8e50c7fa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab8e79e86f7742d8b372e78
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab8e9fcd8ce870019439434
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab8ebf186f7742d8b372e80
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab8ee7786f7742d8f33f0b9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab8f04f86f774585f4237d8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab8f20c86f7745cdb629fb2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab8f39486f7745cd93a1cca
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab8f4ff86f77431c60d91ba
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ab8f85d86f7745cd93a1cf5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aba62f8d8ce87001943946b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aba637ad8ce87001773e17f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5aba639ed8ce8700182ece67
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5abcbb20d8ce87001773e258
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5abcbc27d8ce8700182eceeb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5abcc328d8ce8700194394f3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5abccb7dd8ce87001773e277
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5abcd472d8ce8700166032ae
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac23c6186f7741247042bad
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac2426c86f774138762edfe
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac2428686f77412450b42bf
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac242ab86f77412464f68b4
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac244c486f77413e12cf945
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac244eb86f7741356335af1
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac345dc86f774288030817f
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac3460c86f7742880308185
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac3462b86f7741d6118b983
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac3464c86f7741d651d6877
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac3467986f7741d6224abc2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac346a886f7744e1b083d67
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac346cf86f7741d63233a02
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac346e886f7741d6118b99b
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac3475486f7741d6224abd3
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac3477486f7741d651d6885
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac3479086f7742880308199
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ac3b934156ae10c4430e83c
        {
            public string Description { get; set; }
            public string FirstName { get; set; }
            public string FullName { get; set; }
            public string Location { get; set; }
            public string Nickname { get; set; }
        }

        public class _5ac4ab8886f7747d0f66429a
        {
            public object Name { get; set; }
        }

        public class _5ac4abf986f7747d117c67aa
        {
            public object Name { get; set; }
        }

        public class _5ac4ac9486f774181345c3d2
        {
            public string Name { get; set; }
        }

        public class _5ac4accf86f774181345c3d7
        {
            public string Name { get; set; }
        }

        public class _5ac4ad3686f774181345c3da
        {
            public string Name { get; set; }
        }

        public class _5ac4ad7586f7747d14551da3
        {
            public string Name { get; set; }
        }

        public class _5ac4c50d5acfc40019262e87
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac4cd105acfc40016339859
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac50c185acfc400163398d4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac50da15acfc4001718d287
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac620eb86f7743a8e6e0da0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac66bea5acfc43b321d4aec
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac66c5d5acfc4001718d314
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac66cb05acfc40198510a10
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac66d015acfc400180ae6e4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac66d2e5acfc43b321d4b53
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac66d725acfc43b321d4b60
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac66d9b5acfc4001633997a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac72e475acfc400180ae6fe
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac72e615acfc43f67248aa0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac72e725acfc400180ae701
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac72e7d5acfc40016339a02
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac72e895acfc43b321d4bd5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac72e945acfc43f3b691116
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac733a45acfc400192630e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac7655e5acfc40016339a19
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac78a9b86f7741cca0bbd8d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac78eaf5acfc4001926317a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ac8d6885acfc400180ae7b0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5accd88b86f774112d7173bb
        {
            public string Name { get; set; }
        }

        public class _5acf7db286f7743a9c7092e3
        {
            public object Name { get; set; }
        }

        public class _5acf7dd986f774486e1281bf
        {
            public object Name { get; set; }
        }

        public class _5acf7dfc86f774401e19c390
        {
            public object Name { get; set; }
        }

        public class _5acf7e2b86f7740874790e20
        {
            public object Name { get; set; }
        }

        public class _5acf7e4c86f774499a3f3bdd
        {
            public object Name { get; set; }
        }

        public class _5acf7e7986f774401e19c3a0
        {
            public object Name { get; set; }
        }

        public class _5ad5ccd186f774446d5706e9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ad5cfbd86f7742c825d6104
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ad5d20586f77449be26d877
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ad5d49886f77455f9731921
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ad5d64486f774079b080af8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ad5d7d286f77450166e0a89
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ad5db3786f7743568421cce
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ad7217186f7746744498875
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ad7242b86f7740a6a3abd43
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ad7247386f7747487619dc3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ad74cf586f774391278f6f0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addaffe86f77470b455f900
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addba3e5acfc4001669f0ab
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addbac75acfc400194dbc56
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addbb6e5acfc408fb1393fd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addbb825acfc408fb139400
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addbb945acfc4001a5fc44e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addbba15acfc400185c2854
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addbbb25acfc40015621bd9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addbf175acfc408fb13965b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addbfbb5acfc400194dbcf7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addbfd15acfc40015621bde
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addbfe15acfc4001a5fc58b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addbfef5acfc400185c2857
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addbffe5acfc4001714dfac
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addc00b5acfc4001669f144
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addc7005acfc4001669f275
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addc7ac5acfc400194dbd90
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addc7db5acfc4001669f279
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addcce35acfc4001a5fc635
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5addccf45acfc400185c2989
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ade141a86f77433a66ae764
        {
            public string Name { get; set; }
        }

        public class _5ade143e86f7745ee356674e
        {
            public string Name { get; set; }
        }

        public class _5adf23995acfc400185c2aeb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae08f0a5acfc408fb1398a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae096d95acfc400185c2c81
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae0973a5acfc4001562206c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae099875acfc4001714e593
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae099925acfc4001a5fc7b3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae09bff5acfc4001562219d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae30bad5acfc400185c2dc4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae30c9a5acfc408fb139a03
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae30db85acfc408fb139a05
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae30e795acfc408fb139a0b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae3267986f7742a413592fe
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae3270f86f77445ba41d4dd
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae3277186f7745973054106
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae327c886f7745c7b3f2f3f
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae3280386f7742a41359364
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae35b315acfc4001714e8b0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae448a386f7744d3730fff0
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae448bf86f7744d733e55ee
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae448e586f7744dcf0c2a67
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae448f286f77448d73c0131
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae4490786f7744ca822adcc
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae4493486f7744efa289417
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae4493d86f7744b8e15aa8f
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae4495086f77443c122bc40
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae4495c86f7744e87761355
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae4496986f774459e77beb6
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae4497b86f7744cf402ed00
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae4498786f7744bde357695
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae4499a86f77449783815db
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae449a586f7744bde357696
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae449b386f77446d8741719
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae449c386f7744bde357697
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae449d986f774453a54a7e1
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ae9a0dd86f7742e5f454a05
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae9a18586f7746e381e16a3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae9a1b886f77404c8537c62
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae9a25386f7746dd946e6d9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae9a3f586f7740aab00e4e6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ae9a4fc86f7746e381e1753
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5af0454c86f7746bf20992e8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5af0484c86f7740f02001f7f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5af04b6486f774195a3ebb49
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5af04c0b86f774138708f78e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5af04e0a86f7743a532b79e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5af0534a86f7743b6f354284
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5af0548586f7743a532b7e99
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5af0561e86f7745f5f3ad6ac
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5af08bfd86f774223d4528e2
        {
            public string Name { get; set; }
        }

        public class _5af08c4486f774223b094223
        {
            public string Name { get; set; }
        }

        public class _5af08cc686f77424a61595f2
        {
            public string Name { get; set; }
        }

        public class _5af08cf886f774223c269184
        {
            public string Name { get; set; }
        }

        public class _5af08d1c86f774223a7aa1b4
        {
            public string Name { get; set; }
        }

        public class _5af99e9186f7747c447120b8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5afd7ded5acfc40017541f5e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5afd7e095acfc40017541f61
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5afd7e445acfc4001637e35a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b02be8586f77469b52d03cc
        {
            public object Name { get; set; }
        }

        public class _5b04473a5acfc40018632f70
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b057b4f5acfc4771e1bd3e9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b05929186f774218854222a
        {
            public object Name { get; set; }
        }

        public class _5b07db875acfc40dc528a5f6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b07dd285acfc4001754240d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b0800175acfc400153aebd4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b099a765acfc47a8607efe3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b099a9d5acfc47a8607efe7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b099ac65acfc400186331e1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b099b7d5acfc400186331e4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b099b965acfc400186331e6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b099bb25acfc400186331e8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b099bf25acfc4001637e683
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b0bbe4e5acfc40dc528a72d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b0bc22d5acfc47a8607f085
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b0e794b5acfc47a877359b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b0fc42d86f7744a585f9105
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b1fa9b25acfc40018633c01
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b1fa9ea5acfc40018633c0a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b1faa0f5acfc40dc528aeb5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b1fb3e15acfc4001637f068
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b1fd4e35acfc40018633c39
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b222d335acfc4771e1be099
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b222d405acfc400153af4fe
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b2240bf5acfc40dc528af69
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b237e425acfc4771e1be0b6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b2388675acfc4771e1be0be
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b2389515acfc4771e1be0c0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b2a197486f7742bae56f2c7
        {
            public object Name { get; set; }
        }

        public class _5b2a199a86f77425da37d5f2
        {
            public object Name { get; set; }
        }

        public class _5b2a19c186f77465d00f1f45
        {
            public string Name { get; set; }
        }

        public class _5b2a27a086f774138422495d
        {
            public string Name { get; set; }
        }

        public class _5b2cfa535acfc432ff4db7a0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b30ac585acfc433000eb79c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b30b0dc5acfc400153b7124
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b30bc165acfc40016387293
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b30bc285acfc47a8608615d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b31163c5acfc400153b71cb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3116595acfc40019476364
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3236e186f77408933ec62c
        {
            public string Name { get; set; }
        }

        public class _5b336f4f86f774134c06ecf8
        {
            public string Name { get; set; }
        }

        public class _5b34ae2a86f774559624f17c
        {
            public object Name { get; set; }
        }

        public class _5b363dd25acfc4001a598fd2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b363dea5acfc4771e1c5e7e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b363e1b5acfc4771e1c5e80
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b39f8db5acfc40016387a1b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b39ffbd5acfc47a8773fb06
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3a08b25acfc4001754880c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3a16655acfc40016387a2a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3a337e5acfc4704b4a19a0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3b6dc75acfc47a8773fb1e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3b6e495acfc4330140bd88
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3b713c5acfc4330140bd8d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3b99265acfc4704b4a1afb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3b99475acfc432ff4dcbee
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3baf8f5acfc40dc5296692
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3cadf35acfc400194776a0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3cbc235acfc4001863ac44
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3f16c486f7747c327f55f7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3f3ade86f7746b6b790d8e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3f3af486f774679e752c1f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3f3b0186f774021a2afef7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3f3b0e86f7746752107cda
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3f7bf05acfc433000ecf6b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3f7c005acfc4704b4a1de8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b3f7c1c5acfc40dc5296b1d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b40e1525acfc4771e1c6611
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b40e2bc5acfc40016388216
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b40e3f35acfc40016388218
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b40e4035acfc47a87740943
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b40e5e25acfc4001a599bea
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b40e61f5acfc4001a599bec
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b43237186f7742f3a4ab252
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b4325355acfc40019478126
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b4326435acfc433000ed01d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b43271c5acfc432ff4dce65
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b4327aa5acfc400175496e0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b4329075acfc400153b78ff
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b4329f05acfc47a86086aa1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b432b2f5acfc4771e1c6622
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b432b6c5acfc4001a599bf0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b432b965acfc47a8774094e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b432be65acfc433000ed01f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b432c305acfc40019478128
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b432d215acfc4771e1c6624
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b432f3d5acfc4704b4a1dfb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b4335ba86f7744d2837a264
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b43575a86f77424f443fe62
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b4391a586f7745321235ab2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b439b1f86f7744fd8059cbe
        {
            public string Name { get; set; }
        }

        public class _5b439b5686f77428bd137424
        {
            public string Name { get; set; }
        }

        public class _5b4476d286f774279043d9ab
        {
            public string Name { get; set; }
        }

        public class _5b44776086f774270225f9d7
        {
            public string Name { get; set; }
        }

        public class _5b44abe986f774283e2e3512
        {
            public string Name { get; set; }
        }

        public class _5b44c6ae86f7742d1627baea
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b44c8ea86f7742d1627baf1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b44cad286f77402a54ae7e5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b44cd8b86f774503d30cba2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b44cf1486f77431723e3d05
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b44d0de86f774503d30cba8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b44d22286f774172b0c9de8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b46238386f7741a693bcf9c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b4736a986f774040571e998
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b4736b986f77405cb415c10
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b47749f86f7746c5d6a5fd4
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5b47799d86f7746c5d6a5fd8
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5b477b6f86f7747290681823
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5b477f7686f7744d1b23c4d2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5b47825886f77468074618d3
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5b47876e86f7744d1c353205
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5b47891f86f7744d1b23c571
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5b478b1886f7744d1b23c57d
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5b478d0f86f7744d190d91b5
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5b478eca86f7744642012254
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5b478ff486f7744d184ecbbf
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5b47926a86f7747ccc057c15
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5b4794cb86f774598100d5d4
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5b4795fb86f7745876267770
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5b4c72b386f7745b453af9c0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b4c72c686f77462ac37e907
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b4c72fb86f7745cef1cffc5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b4c81a086f77417d26be63f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b4c81bd86f77418a75ae159
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b6d9ce188a4501afc1b2b25
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7be1125acfc4001876c0e5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7be1265acfc400161d0798
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7be1ca5acfc400170e2d2f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7be2345acfc400196d524a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7be4575acfc400161d0832
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7be4645acfc400170e2dcc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7be46e5acfc400170e2dcf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7be47f5acfc400170e2dd2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7be4895acfc400170e2dd5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7bebc85acfc43bca706666
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7bed205acfc400161d08cc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7bedd75acfc43d825283f9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7bee755acfc400196d5383
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7bef1e5acfc43d82528402
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7bef5d5acfc43bca7067a3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7bef9c5acfc43d102852ec
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7c2d1d5acfc43d1028532a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7c710788a4506dec015957
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7d37845acfc400170e2f87
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7d63b75acfc400170e2f8a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7d63cf5acfc4001876c8df
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7d63de5acfc400170e2f8d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7d64555acfc4001876c8e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7d645e5acfc400170e2f90
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7d671b5acfc43d82528ddd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7d678a5acfc4001a5c4022
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7d679f5acfc4001a5c4024
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7d68af5acfc400170e30c3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7d693d5acfc43bca706a3d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b7d6c105acfc40015109a5f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b800e9286f7747a8b04f3ff
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b800ebc86f774394e230a90
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b800ed086f7747baf6e2f9e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b80242286f77429445e0b47
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b83f22086f77464e15a1d5f
        {
            public string Name { get; set; }
        }

        public class _5b83f23a86f7746d3d190a73
        {
            public string Name { get; set; }
        }

        public class _5b83f29886f7746d956305a1
        {
            public string Name { get; set; }
        }

        public class _5b84038986f774774913b0c1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b8403a086f7747ff856f4e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5b8683a486f77467f2423114
        {
            public string Name { get; set; }
        }

        public class _5b86a0e586f7745b600ccb23
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ba26383d4351e00334c93d9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ba264f6d4351e0034777d52
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ba2657ed4351e0035628ff2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ba26586d4351e44f824b340
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ba2678ad4351e44f824b344
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5ba26812d4351e003201fef1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5ba26835d4351e0035628ff5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5ba26844d4351e00334c9475
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5ba26acdd4351e003562908e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ba26ae8d4351e00367f9bdb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ba26b01d4351e0085325a51
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ba26b17d4351e00367f9bdd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ba36f85d4351e0085325c81
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ba3a078d4351e00334c96ca
        {
            public string Name { get; set; }
        }

        public class _5ba3a14cd4351e003202017f
        {
            public string Name { get; set; }
        }

        public class _5ba3a3dfd4351e0032020190
        {
            public string Name { get; set; }
        }

        public class _5ba3a449d4351e0034778243
        {
            public string Name { get; set; }
        }

        public class _5ba3a4d1d4351e4502010622
        {
            public string Name { get; set; }
        }

        public class _5ba3a53dd4351e3bac12056e
        {
            public string Name { get; set; }
        }

        public class _5bae13bad4351e00320204af
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bae13ded4351e44f824bf38
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20d53d4351e4502010a69
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20d92d4351e00853263eb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20d9cd4351e00334c9d8a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20da5d4351e0035629dbf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20dadd4351e00367faeff
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20dbcd4351e44f824c04e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20dcad4351e3bac1212da
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20de5d4351e0035629e59
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20df1d4351e00347787d5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20dfcd4351e00334c9e24
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20e0ed4351e3bac1212dc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20e18d4351e00320205d5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20e49d4351e3bac1212de
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20e58d4351e00320205d7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb20e70d4351e0035629f8f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bb2475ed4351e00853264e3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bbdb811d4351e45020113c7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bbdb83fd4351e44f824c44b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bbdb870d4351e00367fb67d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bbdb8bdd4351e4502011460
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bbde409d4351e003562b036
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bbde41ed4351e003562b038
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bbf1c1c88a45017144d28c5
        {
            public string Name { get; set; }
        }

        public class _5bbf1c5a88a45017bb03d7aa
        {
            public string Name { get; set; }
        }

        public class _5bc09a18d4351e003562b68e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc09a30d4351e00367fb7c8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc4776586f774512d07cf05
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5bc479e586f7747f376c7da3
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5bc47dbf86f7741ee74e93b9
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5bc480a686f7741af0342e29
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5bc4826c86f774106d22d88b
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5bc4836986f7740c0152911c
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5bc4856986f77454c317bea7
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5bc4893c86f774626f5ebf3e
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5bc5a351d4351e003477a414
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc5a35cd4351e450201232f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc5a372d4351e44f824d17f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc9b156d4351e00367fbce9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc9b355d4351e6d1509862a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc9b720d4351e450201234b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc9b9ecd4351e3bac122519
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc9bc53d4351e00367fbcee
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc9bdb8d4351e003562b8a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc9be8fd4351e00334cae6e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc9c049d4351e44f824d360
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc9c1e2d4351e00367fbcf0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc9c29cd4351e003562b8a3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bc9c377d4351e3bac12251b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bcf0213d4351e0085327c17
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bd056fa86f7743aba7658cd
        {
            public string Name { get; set; }
        }

        public class _5bd05f1186f774572f181678
        {
            public string Name { get; set; }
        }

        public class _5bd06f5d86f77427101ad47c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bd0716d86f774171822ef4b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bd071d786f7747e707b93a3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bd073a586f7747e6f135799
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bd073c986f7747f627e796c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bd70322209c4d00d7167b8f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bd704e7209c4d00d7167c31
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bdb3ac186f77405f232ad22
        {
            public string Name { get; set; }
        }

        public class _5be4038986f774527d3fae60
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bead2e00db834001c062938
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bed61680db834001d2c45ab
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bed625c0db834001c062946
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5beec1bd0db834001e6006f3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5beec2820db834001b095426
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5beec3420db834001b095429
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5beec3e30db8340019619424
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5beec8b20db834001961942a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5beec8c20db834001d2c465c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5beec8ea0db834001a6f9dbf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5beec91a0db834001961942d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5beec9450db83400970084fd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5beecbb80db834001d2c465e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5beed0f50db834001c062b12
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bf3e03b0db834001d2c4a9c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bf3e0490db83400196199af
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bf3f59f0db834001a6fa060
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfd297f0db834001a669119
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfd35380db83400232fe5cc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfd36290db834001966869a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfd36ad0db834001c38ef66
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfd37c80db834001d23e842
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfd384c0db834001a6691d3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfd4c980db834001b73449d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfd4cbe0db834001b73449f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfd4cc90db834001d23e846
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfd4cd60db834001c38f095
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfe7fb30db8340018089fed
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfe86a20db834001d23e8f7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfe86bd0db83400232fe959
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfe86df0db834001b734685
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfe89510db834001808a127
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfea6e90db834001b7347f3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfea7ad0db834001c38f1ee
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfeaa0f0db834001b734927
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfeb32b0db834001a6694d9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfebc250db834001a6694e1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfebc320db8340019668d79
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfebc530db834001d23eb65
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bfebc5e0db834001a6694e5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bffcf7a0db83400232fea79
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bffd7ed0db834001d23ebf9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bffdc370db834001d23eca8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bffdd7e0db834001b734a1a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bffe7930db834001b734a39
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bffe7c50db834001d23ece1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bffec120db834001c38f5fa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5bffef760db8340019668fe4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0000c00db834001a6697fc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0006470db834001a6697fe
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c00076d0db834001d23ee1f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0009510db834001966907f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0102aa0db834001b734ba1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0102b20db834001d23eebc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c010a700db834001d23ef5d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c010e350db83400232feec7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0111ab0db834001966914d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0125fc0db834001a669aa3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0126f40db834002a125382
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c012ffc0db834001d23f03f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0505e00db834001b735073
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0517910db83400232ffee5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c05293e0db83400232fff80
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c05295e0db834001a66acbb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c052a900db834001a66acbd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c052cea86f7746b2101e8d8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c052e6986f7746b207bc3c9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c052f6886f7746b1e3db148
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c052fb986f7746b2101e909
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c05300686f7746dce784e5d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c05308086f7746b2101e90b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0530ee86f774697952d952
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c05413a0db834001c390617
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0548ae0db834001966a3c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0558060db834001b735271
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0647fdd443bc2504c2d371
        {
            public string Description { get; set; }
            public string FirstName { get; set; }
            public string FullName { get; set; }
            public string Location { get; set; }
            public string Nickname { get; set; }
        }

        public class _5c064c400db834001d23f468
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c06595c0db834001a66af6c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c066e3a0db834001b7353f0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c066ef40db834001966a595
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0672ed0db834001b7353f3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0673fb0db8340023300271
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c06779c86f77426e00dd782
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c06782b86f77426df5407d2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0684e50db834002a12585a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0695860db834001b735461
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0696830db834001d23f5da
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c06c6a80db834001b735491
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c079ec50db834001966a706
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c079ed60db834001a66b372
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c07a8770db8340023300450
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c07b36c0db834002a1259e9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c07b3850db834002330045b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c07c5ed0db834001b73571c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c07c60e0db834002330051f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c07c9660db834001a66b588
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c07dd120db834001c39092d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c07df7f0db834001b73588a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c08f87c0db8340019124324
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0919b50db834001b7ce3b9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c091a4e0db834001d5addc8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c093ca986f7740a1867ab12
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c093db286f7740a1b2617e3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c093e3486f77430cb02e593
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0a2cec0db834001b7ce47d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0a794586f77461c458f892
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0a840b86f7742ffa4f2482
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0bbaa886f7746941031d82
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c0bc91486f7746ab41857a2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c0bd01e86f7747cdd799e56
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c0bd94186f7747a727f09b2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c0bdb5286f774166e38eed4
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c0bde0986f77479cf22c2f8
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c0be13186f7746f016734aa
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c0be5fc86f774467a116593
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c0c1dba86f7743e667da897
        {
            public string Name { get; set; }
        }

        public class _5c0c1dff86f7744dba7a2892
        {
            public string Name { get; set; }
        }

        public class _5c0c1f2b86f77455912eaefc
        {
            public string Name { get; set; }
        }

        public class _5c0c1fc586f77455912eaf08
        {
            public string Name { get; set; }
        }

        public class _5c0c202e86f77448687e0368
        {
            public string Name { get; set; }
        }

        public class _5c0c208886f7743e5335d279
        {
            public string Name { get; set; }
        }

        public class _5c0c20f586f7745352630cde
        {
            public string Name { get; set; }
        }

        public class _5c0d0d5086f774363760aef2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c0d0f1886f77457b8210226
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c0d190cd09282029f5390d8
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c0d1c4cd0928202a02a6f5c
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c0d1ec986f77439512a1a72
        {
            public string Name { get; set; }
        }

        public class _5c0d2727d174af02a012cf58
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0d32fcd174af02a1659c75
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0d4c12d09282029f539173
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c0d4e61d09282029f53920e
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c0d56a986f774449d5de529
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5c0d591486f7744c505b416f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5c0d5ae286f7741e46554302
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5c0d5e4486f77478390952fe
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5c0d668f86f7747ccb7f13b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5c0d688c86f77413ae3407b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5c0e2f26d174af02a9625114
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e2f5cd174af02a012cfc9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e2f94d174af029f650d56
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e2ff6d174af02a1659d4a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e3eb886f7742015526062
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e446786f7742013381639
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e51be86f774598e797894
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e530286f7747fa1419862
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e531286f7747fa54205c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e531d86f7747fa23f4d42
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e533786f7747fa23f4d47
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e534186f7747fa1419867
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e53c886f7747fa54205c7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e541586f7747fa54205c9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e57ba86f7747fa141986d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e5bab86f77461f55ed1f3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e5edb86f77461f55ed1f7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e625a86f7742d77340f62
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e655586f774045612eeb2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e66e2d174af02a96252f4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e6a1586f77404597b4965
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e722886f7740458316a57
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e746986f7741453628fe5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e774286f77468413cc5b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e805e86f774683f3dd637
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e842486f77443a74d2976
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e874186f7745dc7616606
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0e93cb86f77432297fdfc8
        {
            public string Name { get; set; }
        }

        public class _5c0e9f2c86f77432297fe0a3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0fa877d174af02a012e1cf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0faeddd174af02a962601f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0faf68d174af02a96260b8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c0fafb6d174af02a96260ba
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c10c8fd86f7743d7d706df3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c10f94386f774227172c572
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c10fcb186f774533e5529ab
        {
            public string Name { get; set; }
        }

        public class _5c11046cd174af02a012e42b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c110624d174af029e69734c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c11279ad174af029d64592b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1127bdd174af44217ab8b9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1127d0d174af29be75cf68
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1128e386f7746565181106
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c112d7e86f7740d6f647486
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c1141f386f77430ff393792
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c12301c86f77419522ba7e4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1234c286f77406fa13baeb
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c123fe086f7742a60324263
        {
            public string Name { get; set; }
        }

        public class _5c12452c86f7744b83469073
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c1260dc86f7746b106e8748
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c12613b86f7743bbe2c3f76
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c12619186f7743f871c8a32
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c12620d86f7743f8b198b72
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1262a286f7743f8a69aab2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1265fc86f7743f896a21c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1267ee86f77416ec610f72
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c12688486f77426843c7d32
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c127c4486f7745625356c13
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c139eb686f7747878361a6f
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c13cd2486f774072c757944
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c13cef886f774072e618e82
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c165d832e2216398b5a7e36
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c17664f2e2216398b5a7e3c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1780312e221602b66cc189
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c17804b2e2216152006c02f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c178a942e22164bef5ceca3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1793902e221602b21d3de2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c17a7ed2e2216152142459c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c18b90d2e2216152142466b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c18b9192e2216398b5a8104
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1a1cc52e221602b3136e3d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1a1e3f2e221602b66cc4c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1b857086f77465f465faa4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1bc4812e22164bef5cfde7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1bc5612e221602b5429350
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1bc5af2e221602b412949b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1bc5fb2e221602b1779b32
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1bc7432e221602b412949d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1bc7752e221602b1779b34
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1cd46f2e22164bef5cfedb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1cdd302e221602b3137250
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1cdd512e22161b267d91ae
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1d0c5f86f7744bb2683cf0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1d0d6d86f7744bb2683e1f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1d0dc586f7744baf2e7b79
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1d0efb86f7744baf2e7b7b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1d0f4986f7744bb01837fa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1e2a1e86f77431ea0ea84c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1e2d1f86f77431e9280bee
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1e495a86f7743109743dfb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c1f79a086f7746ed066fb8f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c3df7d588a4501f290594e5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5c46fbd72e2216398b5a8c9c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c471b5d2e221602b21d4e14
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c471b7e2e2216152006e46c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c471ba12e221602b3137d76
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c471bd12e221602b4129c3a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c471be12e221602b66cd9ac
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c471bfc2e221602b21d4e17
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c471c2d2e22164bef5d077f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c471c442e221602b542a6f8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c471c6c2e221602b66cd9ae
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c471c842e221615214259b5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c471cb32e221602b177afaa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c488a752e221602b412af63
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c48a14f2e2216152006edd7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c48a2852e221602b21d5923
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c48a2a42e221602b66d1e07
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c48a2c22e221602b313fb6c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c4ee3d62e2216152006f302
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c4eec9b2e2216398b5aaba2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c4eecc32e221602b412b440
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c4eecde2e221602b3140418
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c501a4d2e221602b412b540
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5039be2e221602b177c9ff
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c503ac82e221602b21d6e9a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c503ad32e2216398b5aada2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c503af12e221602b177ca02
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c503b1c2e221602b21d6e9d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c503d0a2e221602b542b7ef
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c51aac186f77432ea65c552
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5c5952732e2216398b5abda2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c59529a2e221602b177d160
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5970672e221602b21d7855
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5db5852e2216003a0fe71a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5db5962e2216000e5e46eb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5db5b82e2216003a0fe71d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5db5c62e22160012542255
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5db5f22e2216000e5e47e8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5db5fc2e2216000f1b2842
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5db6302e2216000e5e47f0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5db63a2e2216000f1b284a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5db6552e2216001026119d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5db6652e221600113fba51
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5db6742e2216000f1b2852
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5db6b32e221600102611a0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5db6ee2e221600113fba54
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c5db6f82e2216003a0fe914
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6161fb2e221600113fbde5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6162682e22160010261a2b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c61627a2e22160012542c55
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6165902e22160010261b28
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6175362e221600133e3b94
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c617a5f2e2216000f1e81b3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c61a40d2e2216001403158d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6592372e221600133e47d7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6beec32e221601da3578f2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6bf4aa2e2216001219b0ae
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6c2c9c2e2216000f2002e4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6d10e82e221601da357b07
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6d10fa2e221600106f3f23
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6d11072e2216000e69d2e4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6d11152e2216000f2003e7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6d42cb2e2216000e69d7d1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6d450c2e221600114c997d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6d46132e221601da357d56
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6d5d8b2e221644fc630b39
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6d710d2e22165df16b81e7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6d7b3d2e221600114c9b7d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c6d85e02e22165df16b81f4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c78f2492e221600114c9f04
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c78f2612e221600114c9f0d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c78f26f2e221601da3581d1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c78f2792e221600106f4683
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c78f2882e22165df16b832e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c791e872e2216001219c40a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c793fb92e221644f31bfb64
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c793fc42e221600114ca25d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c793fde2e221601da358614
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c7951452e221644f31bfd5c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c7954d52e221600106f4cc7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c7955c22e221644f31bfd5e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c7d55de2e221644f31bff68
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c7d55f52e221644f31bff6a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c7d560b2e22160bc12c6139
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c7e5f112e221600106f4ede
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c7e8fab2e22165df16b889b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c7fb51d2e2216001219ce11
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c7fc87d2e221644f31c0298
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c82342f2e221644f31c060e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c82343a2e221644f31c0611
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c86592b2e2216000e69e77c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c878e9d2e2216000f201903
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c878ebb2e2216001219d48a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c87a07c2e2216001219d4a2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c87ca002e221600114cb150
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c88f24b2e22160bc12c69a6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c90c3622e221601da359851
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c920e902e221644f31c3c99
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c925fa22e221601da359b7b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5c94bbff86f7747ee735c08f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c98bd7386f7740cfb15654e
        {
            public string Name { get; set; }
        }

        public class _5c99f3592e221644fc633070
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c9a07572e221644f31c4b32
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c9a1c3a2e2216000e69fb6a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c9a1c422e221600106f69f0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c9a25172e2216000f20314e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5c9a26332e2216001219ea70
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ca20abf86f77418567a43f2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ca20d5986f774331e7c9602
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ca20ee186f774799474abc2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ca2113f86f7740b2547e1d2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ca2151486f774244a3b8d30
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ca21c6986f77479963115a7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cadc190ae921500103bb3b6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cadc1c6ae9215000f2775a4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cadc2e0ae9215051e1c21e7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cadc390ae921500126a77f1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cadc431ae921500113bb8d5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cadc55cae921500103bb3be
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cadd919ae921500126a77f3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cadd940ae9215051e1c2316
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cadd954ae921500103bb3c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cadf6ddae9215051e1c23b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5cadf6e5ae921500113bb973
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5cadf6eeae921500134b2799
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5cadfbf7ae92152ac412eeef
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5caf1041ae92157c28402e3f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5caf1109ae9215753c44119f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5caf1691ae92152ac412efb9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5caf16a2ae92152ac412efbc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5caf17c9ae92150b30006be1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5caf187cae92157c28402e43
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cbda392ae92155f3c17c39f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cbda9f4ae9215000e5b9bfc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cbdaf89ae9215000e5b9c94
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cbdb1b0ae9215000d50e105
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cbdc23eae9215001136a407
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc084dd14c02e000b0550a3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc0858d14c02e000c6bea66
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc085bb14c02e000e67a5c5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc6ea78e4a949000e1ea3c1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc6ea85e4a949000e1ea3c3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc70093e4a949033c734312
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc700b9e4a949000f0f0f25
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc700cae4a949035e43ba72
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc700d4e4a949000f0f0f28
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc700ede4a949033c734315
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc70102e4a949035e43ba74
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc7012ae4a949001252b43e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc70146e4a949000d73bf6b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc7015ae4a949001152b4c6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc701aae4a949000e1ea45c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc701d7e4a94900100ac4e7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc80f38e4a949001152b560
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5cc80f53e4a949000e1ea4f8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5cc80f67e4a949035e43bbba
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5cc80f79e4a949033c7343b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5cc80f8fe4a949033b0224a2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5cc82796e24e8d000f5859a8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc82d76e24e8d00134b4b83
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc86832d7f00c000d3a6e6c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5cc86840d7f00c002412c56c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5cc9a96cd7f00c011c04e04a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc9ad73d7f00c000e2579d4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc9b815d7f00c000e2579d6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc9bcaed7f00c011c04e179
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cc9c20cd7f00c001336c65d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cd945d71388ce000a659dfb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cd946231388ce000d572fe3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cda9bcfd7f00c0c0b53e900
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cdaa99dd7f00c002412d0b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cdd7685d7f00c000f260ed2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cdd7693d7f00c0010373aa5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cde739cd7f00c0010373bd3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cde77a9d7f00c000f261009
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cde7afdd7f00c000d36b89d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cde7b43d7f00c000d36b93e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cde8864d7f00c0010373be1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5cde95d97d6c8b647a3769b0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cde95ef7d6c8b04713c4f2d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cde96047d6c8b20b577f016
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cde9e957d6c8b0474535da7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cde9ec17d6c8b04723cf479
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cdea3f87d6c8b647a3769b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cdea42e7d6c8b0474535dad
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cdeac22d7f00c000f26168f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cdeac42d7f00c000d36ba73
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cdeac5cd7f00c000f261694
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cdeaca5d7f00c00b61c4b70
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cdeb229d7f00c000e7ce174
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ce69cbad7f00c00b61c5098
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cebec00d7f00c065c53522a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cebec10d7f00c065703d185
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cebec38d7f00c00110a652a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf12a15d7f00c05464b293f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf13123d7f00c1085616a50
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf4e3f3d7f00c06595bc7f0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf4fb76d7f00c065703d3ac
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf50850d7f00c056e24104c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf508bfd7f00c056e24104e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf50fc5d7f00c056c53f83c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf518cfd7f00c065b422214
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf54404d7f00c108840b2ef
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf638cbd7f00c06595bc936
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf639aad7f00c065703d455
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf656f2d7f00c06585fb6eb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf67a1bd7f00c06585fb6f3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf67cadd7f00c065a5abab7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf6935bd7f00c06585fb791
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf6937cd7f00c056c53fb39
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf78496d7f00c065703d6ca
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf78720d7f00c06595bc93e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf79389d7f00c10941a0c4d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf79599d7f00c10875d9212
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf7acfcd7f00c1084477cf2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cf8f3b0d7f00c00217872ef
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cfe8010d7ad1a59283b14c6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cff9e5ed7ad1a09407397d4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cff9e84d7ad1a049e54ed55
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5cffa483d7ad1a049e54ef1c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public int ShortName { get; set; }
        }

        public class _5d00e0cbd7ad1a6c6566a42d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d00ec68d7ad1a04a067e5be
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d00ede1d7ad1a0940739a76
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d00ef6dd7ad1a0940739b16
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d00f63bd7ad1a59283b1c1e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d010d1cd7ad1a59283b1ce7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d0236dad7ad1a0940739d29
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d023784d7ad1a049d4aa7f2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d024f5cd7ad1a04a067e91a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d025cc1d7ad1a53845279ef
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d02676dd7ad1a049e54f6dc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d02677ad7ad1a04a15c0f95
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d026791d7ad1a04a067ea63
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d02778e86f774203e7dedbe
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d02797c86f774203f38e30a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d0375ff86f774186372f685
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d0376a486f7747d8050965c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d03775b86f774203e7e0c4b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d0377ce86f774186372f689
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d03784a86f774203e7e0c4d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d0378d486f77420421a5ff4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d03794386f77420415576f5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d0379a886f77420407aa271
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d03b831d7ad1a04a15c1171
        {
            public string Name { get; set; }
        }

        public class _5d07b91b86f7745a077a9432
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d08d21286f774736e7c94c3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d0a29ead7ad1a0026013f27
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d0a29fed7ad1a002769ad08
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d0a3a58d7ad1a669c15ca14
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d0a3e8cd7ad1a6f6a3d35bd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d0b5cd3d7ad1a3fe32ad263
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d10b49bd7ad1a1a560708b0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d120a10d7ad1a4e1026ba85
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d120a28d7ad1a1c8962e295
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d122e7bd7ad1a07102d6d7f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d123102d7ad1a004e475fe5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d123a3cd7ad1a004e476058
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d123b70d7ad1a0ee35e0754
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d123b7dd7ad1a004f01b262
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d124c01d7ad1a115c7d59fb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d124c0ed7ad1a10d168dd9b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d124c1ad7ad1a12227c53a7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d133067d7ad1a33013f95b4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1340b3d7ad1a0b52682ed7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1340bdd7ad1a0e8d245aab
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1340cad7ad1a0b0b249869
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d135e83d7ad1a21b83f42d8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d135ecbd7ad1a21c176542e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d15ce51d7ad1a1eff619092
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d15cf3bd7ad1a67e71518b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d19cd96d7ad1a4a992c9f52
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b198cd7ad1a604869ad72
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b2f3f86f774252167a52c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b2fa286f77425227d1674
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b2ffd86f77425243e8d17
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b304286f774253763a528
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b309586f77425227d1676
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b313086f77425227d1678
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b317c86f7742523398392
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b31ce86f7742523398394
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b327086f7742525194449
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b32c186f774252167a530
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b33a686f7742523398398
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b36a186f7742523398433
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b371186f774253763a656
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b376e86f774252519444e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b385e86f774252167b98a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b392c86f77425243e98fe
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b39a386f774252339976f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b3a5d86f774252167ba22
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b3f2d86f774253763b735
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1b5e94d7ad1a2b865a96b0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1c702ad7ad1a632267f429
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1c774f86f7746d6620f8db
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1c819a86f774771b0acd6c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f564b86f7744bcb0acd16
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f565786f7743f8362bcd5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f566d86f7744bcd13459a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f567786f7744bcc04874f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f568486f7744bca3f0b98
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f56a686f7744bce0ee9eb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f56c686f7744bcd13459c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f56e486f7744bce0ee9ed
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f56f186f7744bcb0acd1a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f56ff86f7743f8362bcd7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f588e86f7744bcc048753
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f58a086f7743f8362bcd9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f58ab86f7743014162042
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f58bd86f7744bce0ee9ef
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f58cb86f7744bca3f0b9a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f58ed86f7744bcb0acd1c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f590486f7744bcd13459e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f591186f7744bcc048755
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f592286f7743f8362bcdb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f593286f7743014162044
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f609d86f7744bca3f1689
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f60ae86f7744bcc04998b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f60b486f7744bcb0adfa8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f60ca86f7743014163025
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f60f086f7744bce0ef704
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f622186f7744bca3f168c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f622e86f7744bcc04998c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f623386f7744bcd135833
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f623886f7743014163027
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f623e86f7744bce0ef705
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f646286f7744bce0ef70a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f646c86f7743f8362cf3f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f647186f7744bce0ef70c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f647586f7744bcb0adfb0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f647a86f7744bca3f1691
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f647f86f7744bcc04998f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f648a86f7744bcd135841
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f648e86f774301416302b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f649286f7743f8362cf40
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f649886f7744bce0ef70d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d1f819086f7744b355c219b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d23376786f77459bb77d838
        {
            public string Name { get; set; }
        }

        public class _5d23404b86f7740d62079098
        {
            public string Name { get; set; }
        }

        public class _5d2340e986f77461496241bc
        {
            public string Name { get; set; }
        }

        public class _5d23424c86f7740d5e50ce65
        {
            public string Name { get; set; }
        }

        public class _5d23467086f77443f37fc602
        {
            public string Name { get; set; }
        }

        public class _5d235a5986f77443f6329bc6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d235b4d86f7742e017bc88a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d235bb686f77443f4331278
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2369418abbc306c62e0c80
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2495a886f77425cd51e403
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d24b81486f77439c92d6ba8
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25a4a98abbc30b917421a4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d25a6538abbc306c62e630d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d25a6a48abbc306c62e6310
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d25a7b88abbc3054f3e60bc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d25aed386f77442734d25d2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25af8f8abbc3055079fec5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d25b6be86f77444001e1b89
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25bfd086f77442734d3007
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25c81b86f77443e625dd71
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25cf2686f77443e75488d4
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25d0ac8abbc3054f3e61f7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d25d2c186f77443e35162e5
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25dae186f77443e55d2f78
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e29d86f7740a22516326
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e2a986f77409dd5cdf2a
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e2b486f77409de05bba0
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e2c386f77443e7549029
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e2cc86f77443e47ae019
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e2d886f77442734d335e
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e2e286f77444001e2e48
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e2ee86f77443e35162ea
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e43786f7740a212217fa
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e44386f77409453bce7b
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e44f86f77443e625e385
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e45e86f77408251c4bfa
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e46e86f77409453bce7c
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e48186f77443e625e386
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e48d86f77408251c4bfb
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e4ad86f77443e625e387
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e4b786f77408251c4bfc
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e4ca86f77409dd5cdf2c
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d25e4d586f77443e625e388
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d2702e88abbc31ed91efc44
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2703038abbc3105103d94c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d270b3c8abbc3105335cfb8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d270ca28abbc31ee25ee821
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2c76ed48f03532f2136169
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2c770c48f0354b4a07c100
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2c772c48f0355d95672c25
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2c829448f0353a5c7d6674
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2da1e948f035477b1ce2ba
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2dc3e548f035404a1a4798
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2f0d8048f0356c925bc3b0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2f213448f0355009199284
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2f259b48f0355a844acd74
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2f25bc48f03502573e5d85
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2f261548f03576f500e7b7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d2f2ab648f03550091993ca
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d2f2d5748f03572ec0c0139
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d357d6b86f7745b606e3508
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d383e1a86f7742a1468ce63
        {
            public string Name { get; set; }
        }

        public class _5d383ee786f7742a15793860
        {
            public string Name { get; set; }
        }

        public class _5d383f5d86f7742a15793872
        {
            public string Name { get; set; }
        }

        public class _5d38517786f7742a1468cf6a
        {
            public string Name { get; set; }
        }

        public class _5d3eb3b0a4b93615055e84d2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d3eb44aa4b93650d64e4979
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d3eb4aba4b93650d64e497d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d3eb536a4b9363b1f22f8e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d3eb59ea4b9361c284bb4b2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d3eb5b6a4b9361eab311902
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d3eb5eca4b9363b1f22f8e4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d3ec50586f774183a607442
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d3ef698a4b9361182109872
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d403f9186f7743cac3f229b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d40407c86f774318526545a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d40412b86f7743cb332ac3a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d40419286f774318526545f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d4041f086f7743cac3f22a7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d40425986f7743185265461
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d4042a986f7743185265463
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d43021ca4b9362eab4b5e25
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d4405aaa4b9361e6a4e6bd3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d4405f0a4b9361e6a4e6bd9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d440625a4b9361eec4ae6c5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d44064fa4b9361e4f6eb8b5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d44069ca4b9361ebd26fc37
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d4406a8a4b9361e4f6eb8b7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d440b93a4b9364276578d4b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d440b9fa4b93601354d480c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d44334ba4b9362b346d1948
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d443f8fa4b93678dd4a01aa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d4aaa54a4b9365392071170
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d4aaa73a4b9365392071175
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d4aab30a4b9365435358c55
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d4bec3486f7743cac246665
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d4da0cb86f77450fe0a6629
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d4da10986f77450fc65edc3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d4da36686f77421522b35ee
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d52cc5ba4b9367408500062
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d52d479a4b936793d58c76b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d53f4b7a4b936793d58c780
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d5d646386f7742797261fd9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d5d85c586f774279a21cbdb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d5d87f786f77427997cfaef
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d5d8ca986f7742798716522
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d5d940f86f7742797262046
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d5e7d28a4b936645d161203
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d5e9c74a4b9364855191c40
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d5fca1ea4b93635fd598c07
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d63d33b86f7746ea9275524
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d67abc1a4b93614ec50137f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d6d2b5486f774785c2ba8ea
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d6d2bb386f774785b07a77a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d6d2e22a4b9361bd5780d05
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d6d2ef3a4b93618084f58bd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d6d3716a4b9361bc8618872
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d6d3829a4b9361bc8618943
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d6d3943a4b9360dbc46d0cc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d6d3be5a4b9361bc73bc763
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d6e6772a4b936088465b17c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e67fba4b9361bc73bc779
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e6806a4b936088465b17e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e6869a4b9361c140bcfde
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e6891a4b9361bd473feea
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e689ca4b9361bc8618956
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e68a8a4b9360b6c0d54e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e68b3a4b9361bca7e50b5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e68c4a4b9361b93413f79
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e68d1a4b93622fe60e845
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e68dea4b9361bcc29e659
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e68e6a4b9361c140bcfe0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e6911a4b9361bd5780d52
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e695fa4b936359b35d852
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e69b9a4b9361bc8618958
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e69c7a4b9360b6c0d54e4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e6a05a4b93618084f58d0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e6a42a4b9364f07165f52
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e6a53a4b9361bd473feec
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6e6a5fa4b93614ec501745
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d6fb2c086f77449da599c24
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d6fbc2886f77449d825f9d3
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5d6fc78386f77449d825f9dc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d6fc87386f77449db3db94e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d6fd13186f77424ad2a8c69
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d6fd45b86f774317075ed43
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d6fe50986f77449d97f7463
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d70e500a4b9364de70d38ce
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5d7b6bafa4b93652786f4c76
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80c60f86f77440373c4ece
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80c62a86f7744036212b3f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80c66d86f774405611c7d6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80c6c586f77440351beef1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80c6fc86f774403a401e3c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80c78786f774403a401e3e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80c88d86f77440556dbf07
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80c8f586f77440373c4ed0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80c93086f7744036212b41
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80c95986f77440351beef3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80ca9086f774403a401e40
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80cab086f77440535be201
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80cb3886f77440556dbf09
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80cb5686f77440545d1286
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80cb8786f774405611c7d9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80cbd886f77470855c26c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80ccac86f77470841ff452
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80ccdd86f77474f7575e02
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d80cd1a86f77402aa362f42
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d8e0db586f7744450412a42
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d8e0e0e86f774321140eb56
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d8e15b686f774445103b190
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d8e3ecc86f774414c78d05e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d947d3886f774447b415893
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d947d4e86f774447b415895
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d95d6be86f77424444eb3a7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d95d6fa86f77424484aa5e9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d96141523f0ea1b7f2aacab
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5d9f1fa686f774726974a992
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5da46e3886f774653b7a83fe
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5da5cdcd86f774529238fb9b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5da743f586f7744014504f72
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dc53acb86f77469c740c893
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5dcbd56fdbd3d91b3e5468d5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dcbd6b46ec07c0c4347a564
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dcbd6dddbd3d91b3e5468de
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dcbe9431e1f4616d354987e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dcbe965e4ed22586443a79d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dd7f8c524e5d7504a4e3077
        {
            public string Name { get; set; }
        }

        public class _5dd800bde492226366631317
        {
            public string Name { get; set; }
        }

        public class _5dd800eae49222636663133b
        {
            public string Name { get; set; }
        }

        public class _5dd8013ff4c3af18c507b10a
        {
            public string Name { get; set; }
        }

        public class _5ddbbeac582ed30a6134e577
        {
            public string Name { get; set; }
        }

        public class _5de652c31b7e3716273428be
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de653abf76fdc1ce94a5a2a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de65547883dde217541644b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de6556a205ddc616a6bc4f7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de6558e9f98ac2bc65950fc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de655be4a9f347bc92edb88
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de7bd7bfd6b4e6e2276dc25
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de8e67c4a9f347bc92edbd7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de8e8dafd6b4e6e2276dc32
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de8ea8ffd6b4e6e2276dc35
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de8eaadbbaf010b10528a6d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de8eac42a78646d96665d91
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de8f237bbaf010b10528a70
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de8f2d5b74cd90030650c72
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de8fb539f98ac2bc659513a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de8fbad2fbe23140d3ee9c4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de8fbf2b74cd90030650c79
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de8fc0b205ddc616a6bc51b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de910da8b6c4240ba2651b5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5de922d4b11454561e39239f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df24cf80dee1b22f862e9bc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df256570dee1b22f862e9c4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df25b6c0b92095fd441e4cf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df25d3bfd6b4e6e2276dc9a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df35ddddfc58d14537c2036
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df35e59c41b2312ea3334d5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df35e7f2a78646d96665dd4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df35e970b92095fd441e4d2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df35ea9c41b2312ea3334d8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df35eb2b11454561e3923e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df36948bb49d91fb446d5ad
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df38a5fb74cd90030650cb6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df89f1f86f77412631087ea
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df89f8f86f77412672a1e38
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8a08886f7740bfe6df775
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8a2ca86f7740bfe6df777
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8a42886f77412640e2e75
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8a4d786f77412672a1e3b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8a58286f77412631087ed
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8a6a186f77412640e2e80
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8a72c86f77412640e2e83
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8a77486f77412672a1e3f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8ce05b11454561e39243b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8e053bb49d91fb446d6a6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8e085bb49d91fb446d6a8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8e4080b92095fd441e594
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8e5c886f7744a122d6834
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8e65d86f77412672a1e46
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8e72186f7741263108806
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8e75786f7745c67099df4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8e79286f7744a122d6836
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8f535bb49d91fb446d6b0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df8f541c41b2312ea3335e3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df916dfbb49d91fb446d6b9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5df917564a9f347bc92edca3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dfa397fb11454561e39246c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dfa3cd1b33c0951220c079b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dfa3d2b0dee1b22f862eade
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dfa3d45dfc58d14537c20b0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dfa3d7ac41b2312ea33362a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dfa3d950dee1b22f862eae0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dfcd0e547101c39625f66f9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dfce88fe9dc277128008b2e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dfe14f30b92095fd441edaf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dfe6104585a0c3e995c7b82
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dff772da3651922b360bf91
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dff77c759400025ea5150cf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5dff8db859400025ea5150d4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e00903ae9dc277128008b87
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e0090f7e9dc277128008b93
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e00c1ad86f774747333222c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e00cdd986f7747473332240
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e00cfa786f77469dc6e5685
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e01e9e273d8eb11426f5bc3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e01ea19e9dc277128008c0b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e01ef6886f77445f643baa4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e01f31d86f77465cf261343
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e01f37686f774773c6f6c15
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e023cf8186a883be655e54f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5e023d34e8a400319a28ed44
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5e023d48186a883be655e551
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5e023e53d4353e3302577c4c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5e023e6e34d52a55c3304f71
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5e023e88277cce2b522ff2b1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5e208b9842457a4a7a33d074
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e217ba4c1434648c13568cd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2192a498a36665e8337386
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e21a3c67e40bd02257a008a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e21ca18e4d47f0da15e77dd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2aedd986f7746d404f3aa4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2aee0a86f774755a234b62
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2aef7986f7746d3f3c33f5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2af00086f7746d3f3c33f7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2af02c86f7746d420957d4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2af22086f7746d3f3c33fa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2af29386f7746d4159f077
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2af2bc86f7746d3f3c33fc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2af37686f774755a234b65
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2af41e86f774755a234b67
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2af47786f7746d404f3aaa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2af4a786f7746d3f3c3400
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2af4d286f7746d4159f07a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2af51086f7746d3f3c3402
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e2af55f86f7746d4159f07c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e32f56fcb6d5863cc5e5ee4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e340dcdcb6d5863cc5e5efb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e381b0286f77420e3417a74
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5e383a6386f77465910ce1f3
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5e42c71586f7747f245e1343
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e42c81886f7742a01529f57
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e42c83786f7742a021fdf3c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4abb5086f77406975c9342
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4abc1f86f774069619fbaa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4abc6786f77406812bd572
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4abfed86f77406a2713cf7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4ac41886f77406a511c9a8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4bb08f86f774069619fbbc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4bb31586f7740695730568
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4bb35286f77406a511c9bc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4bb39386f774067f79de05
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4bb3b586f77406812bd579
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4bb5e486f77406796b7b9e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4bb6d786f77406975c9364
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4bb6fc86f77406801a74f7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4bb8e686f77406796b7ba2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4bfc1586f774264f7582d3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4d34ca86f774264f758330
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e4d4ac186f774264f758336
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5e4d515e86f77438b2195244
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5e54f62086f774219b0f1937
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e54f6af86f7742199090bf3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e54f76986f7740366043752
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e54f79686f7744022011103
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e56991336989c75ab4f03f6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e5699df2161e06ac158df6f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e569a0156edd02abe09f27d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e569a132642e66b0b68015c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e569a2e56edd02abe09f280
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e71f6be86f77429f2683c44
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e71f70186f77429ee09f183
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e71fad086f77422443d4604
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e73519b0b997b5e887e59b3
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e748327dbe23170e05094f4
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e748d226725d419a47e2101
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e748d9fc73f9622610abb37
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e748df9c73f9622610abb38
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e748e8fa848081e986a58a2
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e74921dc73f9622610abb3e
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e7492c2cdcce040bf508424
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e7493d5c377f60fe17d6ec8
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e749741dec1852497081e69
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e749800e80d6c7ea20e93de
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e7498198f3a2f53cc477e99
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e7498cc2eb35c76f5087a47
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e74990c647a0846684a1db4
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e74a68870d454700576d1fe
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e74a765c377f60fe17d6edb
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e74a8a9dfc5fc63e27a781a
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e74a9be70d454700576d1ff
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e74aafac377f60fe17d6ede
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e74ac3f70d454700576d200
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e74ad13647a0846684a1dc8
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e74b1b201e03f5a8d48aff9
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e74be4c24c2c642fa612776
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e74be7b258b0422556b70d7
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e81c3cbac2bb513793cdc75
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e81c4ca763d9f754677befa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public int ShortName { get; set; }
        }

        public class _5e81c519cb2b95385c177551
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e81c539cb2b95385c177553
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e81c550763d9f754677befd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e81c6a2ac2bb513793cdc7f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e81c6bf763d9f754677beff
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public int ShortName { get; set; }
        }

        public class _5e81ebcd8e146c7080625e15
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e81edc13397a21db957f6a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e81ee213397a21db957f6a6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e81ee4dcb2b95385c177582
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e81f423763d9f754677bf2e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5e831507ea0a7c419c2f9bd9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e84758586f77437b9091fd4
        {
            public string Name { get; set; }
        }

        public class _5e8488fa988a8701445df1e4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e848cc2988a8701445df1e8
        {
            public string Description { get; set; }
            public string FoldedSlot { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e848d1c264f7c180b5e35a9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e848d2eea0a7c419c2f9bfd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e848d51e4dbc5266a4ec63b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e848d99865c0f329958c83b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e848db4681bea2ada00daa9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e848dc4e4dbc5266a4ec63d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e85a9a6eacf8c039e4e2ac1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5e85a9f4add9fe03027d9bf1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5e85aa1a988a8701445df1f5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5e85e1d15549dd01fe748b5a
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e85e2fa5549dd01fe748b5b
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e85e40d5549dd10225137b9
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e85e5025549dda42377fa7b
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e85e77e5549ddf8e2131c0b
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5e870397991fd70db46995c8
        {
            public string Description { get; set; }
            public string FoldedSlot { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e87071478f43e51ca2de5e1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e87076ce2db31558c75a11d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e87080c81c4ed43e83cefda
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e8708d4ae379e67d22e0102
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e87114fe2db31558c75a120
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e87116b81c4ed43e83cefdd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e8f3423fd7471236e6e3b64
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e99711486f7744bfc4af328
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e99735686f7744bfc4af32c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e997f0b86f7741ac73993e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e9d9fa986f774054d6b89f2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e9da17386f774054b6f79a3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e9da2a786f774054c19ac94
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e9dacf986f774054d6b89f4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e9db13186f7742f845ee9d3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e9dc97c86f774054c19ac9a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e9dcadd86f7743e20652f23
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e9dcb8386f774054b6f79a9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e9dcb9c86f7743e20652f25
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e9dcc8a86f77434375990e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e9dccd686f774343b592592
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e9dcf5986f7746c417435b3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5e9de109f6164249e54453d2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea02bb600685063ec28bfa1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea034eb5aad6446a939737b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea034f65aad6446a939737e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea03e5009aa976f2e7a514b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea03e9400685063ec28bfa4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea03f7400685063ec28bfa8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea058e01dbce517f324b3e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea05cf85ad9772e6624305d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea16acdfadf1d18c87b0784
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea16ada09aa976f2e7a51be
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea16d4d5aad6446a939753d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea172e498dacb342978818e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea17bbc09aa976f2e7a51cd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea17ca01412a1425304d1c0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea18c84ecf1982c7712d9a2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ea2a8e200685063ec28c05a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5eaaaa7c93afa0558f3b5a1c
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ebbfe23ba87a5065a00a563
        {
            public string Name { get; set; }
        }

        public class _5ebbff0841a637322117a5fb
        {
            public string Name { get; set; }
        }

        public class _5ed515c8d380ab312177c0fa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ed515e03a40a50460332579
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ed515ece452db0eb56fc028
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ed515f6915ec335206e4152
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ed5160a87bb8443d10680b5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ed51652f6c34d2cc26336a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ed5166ad380ab312177c100
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5eda19f0edce541157209cee
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5edab4b1218d181e29451435
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5edab736cc183c769d778bc2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5edaba7c0c502106f869bc02
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5edabd13218d181e29451442
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5edac020218d181e29451446
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5edac34d0bb72a50635c2bfa
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5edac63b930f5454f51e128b
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ede4739e0350d05467f73e8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5ede47405b097655935d7d16
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5ede474b0c226a66f5402622
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5ede475339ee016e8c534742
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5ede475b549eed7c6d5c18fb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5ede55112c95834b583f052a
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ede567cfa6dc072ce15d6e3
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5ede7a8229445733cb4c18e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ede7b0c6d23e5473e6e8c66
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5eea21647547d6330471b3c9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5eea217fc64c5d0dfc05712a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5eeb2ff5ea4f8b73c827350b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ef1b9f0c64c5d0dfc0571a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ef1ba28c64c5d0dfc0571a5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ef32e4d1c1fd62aea6a150d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ef3448ab37dfd6af863525c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ef3553c43cb350a955a7ccb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ef35bc243cb350a955a7ccd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ef35d2ac64c5d0dfc0571b0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ef35f46382a846010715a96
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ef366938cef260c0642acad
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ef369b08cef260c0642acaf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ef5d994dfbc9f3c660ded95
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5ef61964ec7f42238c31e0c1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5efaf417aeb21837e749c7f2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5efb0c1bd79ff02a1f5e68d9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5efb0cabfb3e451d70735af5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5efb0d4f4bc50b58e81710f3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5efb0da7a29a85116f6ea05f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5efb0e16aeb21837e749c7ff
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5efb0fc6aeb21837e749c801
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5efdaf6de6a30218ed211a48
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5efdafc1e70b5e33f86de058
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5efde6b4f5448336730dbd61
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5eff09cd30a7dc22fd1ddfed
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5eff135be0d3331e9d282b7b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f04886a3937dc337a6b8238
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5f0596629e22f464da6bbdd9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5f0c892565703e5c461894e9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5f2a9575926fd9352339381f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f2aa43ba9b91d26f20ae6d2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f2aa4464b50c14bcf07acdb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f2aa4559b44de6b1b4e68d1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f2aa46b878ef416f538b567
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f2aa47a200e2c0ee46efa71
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f2aa493cd375f14e15eea72
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f2aa49f9b44de6b1b4e68d4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f36a0e5fbf956000b716b65
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f3e76d86cda304dcc634054
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f3e772a670e2a7b01739a52
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f3e777688ca2d00ad199d25
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f3e778efcd9b651187d7201
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f3e77b26cda304dcc634057
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f3e77f59103d430b93f94c1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f3e7801153b8571434a924c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f3e7823ddc4f03b010e2045
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f3e7897ddc4f03b010e204a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f3e78a7fbf956000b716b8e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f4f9eb969cdc30ff33f09db
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5e401747344c2e4f6c42c5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5e40400bc58666c37e7819
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5e4075df4f3100376a8138
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5e40a06760b4138443b341
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5e45cc5021ce62144be7aa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5e467b0bc58666c37e7821
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5e46b96bdad616ad46d613
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5f41476bdad616ad46d631
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5f41f56760b4138443b352
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5f45df0bc58666c37e7832
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5f46086760b4138443b358
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5f46fa5021ce62144be7bd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5f471bdf4f3100376a815e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5f64f947344c2e4f6c431e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5f65180bc58666c37e784a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f5f653179db6e3f0e19b762
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f60b34a41e30a4ab12a6947
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f60b85bbdb8e27dee3dc985
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f60bf4558eff926626a60f2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f60c076f2bcbb675b00dac2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f60c74e3b85f6263c145586
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f60c85b58eff926626a60f7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f60cd6cf2bcbb675b00dac6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f60e6403b85f6263c14558c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f60e7788adaa7100c3adb49
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f60e784f2bcbb675b00dac7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f6331e097199b7db2128dc2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f6336bbda967c74a42e9932
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f6339d53ada5942720e2dc3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f633f68f5750b524b45f112
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f633f791b231926f2329f13
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f633ff5c444ce7e3c30a006
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f63405df5750b524b45f114
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f63407e1b231926f2329f15
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f6340d3ca442212f4047eb2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f6341043ada5942720e2dc5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f63418ef5750b524b45f116
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f6372e2865db925d54f3869
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f647d9f8499b57dc40ddb93
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f647f31b6238e5dd066e196
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5f6770f839a13e712a1dff54
        {
            public string Name { get; set; }
        }

        public class _5f70abfae9f14826bf7c1c65
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5f70acb63a7ec37e73013427
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5f70b9cfe9f14826bf7c1c67
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5f70e2a5dcfde927745eb1d0
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5f710f7ce9f14826bf7c1c72
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5f745ee30acaeb0d490d8c5b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f75c5078fb5c37ce1766e95
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5f75c578dfacb47e146a0062
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5f75fb988fb5c37ce1766e98
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5f75fd4450914c5fcc425279
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5f75fddbd24e8b7a9c508f3a
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5f79c7621f644f1eb53bdaf2
        {
            public Conditions conditions { get; set; }
            public string location { get; set; }
            public string name { get; set; }
        }

        public class _5f99418230835532b445e954
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f994730c91ed922dd355de3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5f9949d869e2777a0e779ba5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fb64bc92b1b027b1f50bcf2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fb651b52b1b027b1f50bcff
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fb651dc85f90547f674b6f4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fb65363d1409e5ca04b54f5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fb653962b1b027b1f50bd03
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fb65424956329274326f316
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fb6548dd1409e5ca04b54f9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fb6558ad6f0b2136f2d7eb7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fb655a72b1b027b1f50bd06
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fb655b748c711690e3a8d5a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fb6564947ce63734e3fa1da
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fb6567747ce63734e3fa1dc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbb976df9986c4cff3fe5f2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbb978207e8a97d1f0902d3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbbaa86f9986c4cff3fe5f6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbbc3324e8a554c40648348
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbbc34106bde7524f03cbe9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbbc366ca32ed67276c1557
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbbc383d5cb881a7363194a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbbfabed5cb881a7363194e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbbfacda56d053a3543f799
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbc210bf24b94483f726481
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbc226eca32ed67276c155d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbc227aa56d053a3543f79e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbc22ccf24b94483f726483
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbcbcf593164a5b6278efb2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbcbd02900b1d5091531dd3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbcbd10ab884124df0cd563
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbcbd6c187fea44d52eda14
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbcc1d9016cce60e8341ab3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbcc3e4d6fa9c00c571bb58
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbcc429900b1d5091531dd7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbcc437d724d907e2077d5c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbcc640016cce60e8341acc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbe3ffdf8b6a877a729ea82
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5fbe760793164a5b6278efc8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fbe7618d6fa9c00c571bb6c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc0f9b5d724d907e2077d82
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc0f9cbd6fa9c00c571bb90
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc0fa362770a0045c59c677
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc0fa957283c4046c58147e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc1221a95572123ae7384a2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc1223595572123ae7384a3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc22d7c187fea44d52eda44
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc23426900b1d5091531e15
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc235db2770a0045c59c683
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc2360f900b1d5091531e19
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc23636016cce60e8341b05
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc23678ab884124df0cd590
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc2369685fd526b824a5713
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc275cf85fd526b824a571a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5fc278107283c4046c581489
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc382a9d724d907e2077dab
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5fc382b6d6fa9c00c571bbc3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5fc382c1016cce60e8341b20
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5fc3e272f8b6a877a729eac5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc3e466187fea44d52eda90
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc3e4a27283c4046c5814ab
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc3e4ee7283c4046c5814af
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc3f2d5900b1d5091531e57
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc4b97bab884124df0cd5e3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc4b992187fea44d52edaa9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc4b9b17283c4046c5814d7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc50bddb4965a7a2f48c5af
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc53954f8b6a877a729eaeb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc5396e900b1d5091531e72
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc614da00efd824885865c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc614f40b735e7b024c76e9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc615110b735e7b024c76ea
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc615710b735e7b024c76ed
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc64ea372b0dd78d51159dc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fc90a5e92565e3d675a7262
        {
            public string Name { get; set; }
        }

        public class _5fca138c2a7b221b2852a5c6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fca13ca637ee0341a484f46
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fce0cf655375d18a253eff0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fce0f9b55375d18a253eff2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fce16961f152d4312622bc9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fce3e0cfe40296c1d5fd782
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fce3e47fe40296c1d5fd784
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fce3e965a9f8c40685693bc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fce42bc187e6a2b994b8247
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fcf63da5c287f01f22bf245
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fcf940bce1ba36a513bb9cc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fcf9477fe40296c1d5fd7c8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fd20ff893a8961fc660a954
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _5fd25119dd870108a754a163
        {
            public string Name { get; set; }
        }

        public class _5fd2517dbdd50d684f73a474
        {
            public string Name { get; set; }
        }

        public class _5fd251a31189a17bcc172662
        {
            public string Name { get; set; }
        }

        public class _5fd251c90d9c95034825edb5
        {
            public string Name { get; set; }
        }

        public class _5fd251ee16cac650092f5d02
        {
            public string Name { get; set; }
        }

        public class _5fd3e77be504291efd0040ad
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fd3e7e2dd870108a754b230
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fd3e8e5bdd50d684f73a51d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fd3e978e504291efd0040b3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fd3e9f71b735718c25cd9f8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fd4c474dd870108a754b241
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fd4c4fa16cac650092f6771
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fd4c5477a8d854fa0105061
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fd4c60f875c30179f5d04c2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fd7910ae3bfcf6cab4c9f55
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fd791b71189a17bcc172f16
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fd8d28367cb5e077335170f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fd9fad9c1ce6b1a3b486d00
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _5fdb4139e4ed5b5ea251e4ed
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fdb50bb2b730a787b3f78cf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fdb5950f5264a66150d1c6e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _5fdb7571e4ed5b5ea251e529
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _600302d73b897b11364cd161
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60098ad7c2240c0fe85c570a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60098af40accd37ef2175f27
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60098b1705871270cd5352a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _601948682627df266209af05
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60194943740c5d77f6705eea
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _601949593ae8f707c4608daa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _601aa3d2b2bcb34913271e6d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _602286df23506e50807090c6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60228924961b8d75ee233c32
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60228a76d62c9b14ed777a66
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60228a850ddce744014caf69
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _602293f023506e50807090cb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60229948cacb6b0506369e27
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _602a95edda11d6478d5a06da
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _602a95fe4e02ce1eaa358729
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _602a97060ddce744014caf6f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _602a9740da11d6478d5a06dc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _602e3f1254072b51b239f713
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _602e620f9b513876d4338d9a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _602e63fb6335467b0c5ac94d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _602e71bd53a60014f9705bfa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _602f85fd9b513876d4338d9c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _603372b4da11d6478d5a07ff
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _603372d154072b51b239f9e1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _603372f153a60014f970616d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _603373004e02ce1eaa358814
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6033749e88382f4fab3fd2c5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60337f5dce399e10262255d1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60338ff388382f4fab3fd2c8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60339954d62c9b14ed777c06
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6033a31e9ec839204e6a2f3e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6033a35f80ae5e2f970ba6bb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6033a3d8ed2e0509b15f9031
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6033a3fee29c9f6c9b14e74e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6033a430ed2e0509b15f9033
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6033fa48ffd42c541047f728
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _603409c80ca681766b6a0fb2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6034cf5fffd42c541047f72e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6034d0230ca681766b6a0fb5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6034d103ca006d2dca39b3f0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6034d2d697633951dc245ea6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6034e3cb0ddce744014cb870
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6034e3d953a60014f970617b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6034e3e20ddce744014cb878
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _603618feffd42c541047f771
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _603619720ca681766b6a0fc4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60361a7497633951dc245eb4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60361b0b5a45383c122086a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60361b5a9a15b10d96792291
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60363c0c92ec1c31037959f5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _603648ff5a45383c122086ac
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _6038b228af2e28262649af14
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6038b24cd6505c1ec64a44a0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6038b4b292ec1c3103795a0b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6038b4ca92ec1c3103795a0d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6038d614d10cbf667352dd44
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60391a8b3364dc22b04d0ce5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60391afc25aff57af81f7085
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60391b0fb847c71012789415
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _603d01a1b41c9b37c6592047
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _603d01b9d10cbf667352dd4a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6040dd4ddcf9592f401632d2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _6040de02647ad86262233012
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60479c3f420fac5ebc199f86
        {
            public string Name { get; set; }
        }

        public class _60479fb29c15b12b9a480fb0
        {
            public string Name { get; set; }
        }

        public class _606587252535c57a13424cfd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60658776f2cb2e02a42ace2b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6065878ac9cf8012264142fd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _606587a88900dc2d9a55b659
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _606587bd6d0bd7580617bacc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _606587d11246154cad35d635
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _606587e18900dc2d9a55b65f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6065880c132d4d12c81fd8da
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6065881d1246154cad35d637
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6065c6e7132d4d12c81fd8e1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6065dc8a132d4d12c81fd8e3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _606dae0ab0e443224b421bb7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _606ee5c81246154cad35d65e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _606eef46232e5a31c233d500
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _606eef756d0bd7580617baf8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _606ef0812535c57a13424d20
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _606f262c6d0bd7580617bafa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _606f263a8900dc2d9a55b68d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _606f26752535c57a13424d22
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _606f2696f2cb2e02a42aceb1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6076c1b9f2cb2e02a42acedc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6076c87f232e5a31c233d50e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60785c0d232e5a31c233d51c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60785ce5132d4d12c81fd918
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _607d5a891246154cad35d6aa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _607d5aa50494a626335e12ed
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _607ea812232e5a31c233d53c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _607f201b3c672b3b3a24a800
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _607f20859ee58b18e41ecd90
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _607ffb988900dc2d9a55b6e4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6086b5392535c57a13424d70
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6086b5731246154cad35d6c7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6086c852c945025d41566124
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6087e0336d0bd7580617bb7a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6087e2a5232e5a31c233d552
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6087e570b998180e9f76dc24
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6087e663132d4d12c81fd96b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60896888e4a85c72ef3fa300
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60896b7bfa70fc097863b8f5
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60896bca6ee58f38c417d4f2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60896e28e4a85c72ef3fa301
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6089732b59b92115597ad789
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6089736efa70fc097863b8f6
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6089743983426423753cd58a
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _608974af4b05530f55550c21
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _608974d01a66564e74191fc0
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _608a768d82e40b3c727fd17d
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _608c22a003292f4ba43f8a1a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60915994c49cf53e4772cc38
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _609267a2bb3f46069c3e6c7d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _609269c3b0e443224b421cc1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60926df0132d4d12c81fd9df
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _609a4b4fe2ff132951242d04
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _609a63b6e2ff132951242d09
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _609b9e31506cf869cf3eaf41
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _609bab8b455afd752b2e6138
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _609e8540d5c319764c2bc2e9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _609e860ebd219504d8507525
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a23797a37c940de7062d02
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a272cc93ef783291411d8e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a2828e8689911a226117f9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a283193cb70855c43a381d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a3b5b05f84d429b732e934
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a3b6359c427533db36cf84
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a3b65c27adf161da7b6e14
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a3c68c37ea821725773ef5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a3c70cde5f453f634816a3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a621c49c197e4e8c4455e6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a6220e953894617404b00a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a6aa8fd559ae040d0d951f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a6aaad42fd2735e4589978
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a7acf20c5cb24b01346648
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a7ad2a2198820d95707a2e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60a7ad3a0c5cb24b0134664a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60b0f561c4449e4cb624c1d7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60b0f6c058e0b0481a09ad11
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60b0f7057897d47c5b04ab94
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60b0f93284c20f0feb453da7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60b0f988c4449e4cb624c1da
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60b52e5bc7d8103275739d67
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60b7c28ee53e4c5c8945dd73
        {
            public string Name { get; set; }
        }

        public class _60b7c2bd95047637182d90a4
        {
            public string Name { get; set; }
        }

        public class _60b7d76e2a3c79100f1979de
        {
            public string Name { get; set; }
        }

        public class _60bf74184a63fc79b60c57f6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60c080eb991ac167ad1c3ad4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60c0c018f7afb4354815096a
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60c7272c204bc17802313365
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60db29ce99594040e04c4a27
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60dc519adf4c47305f6d410d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _60e71b62a0beca400d69efc4
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60e71b9bbd90872cb85440f3
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60e71bb4e456d449cd47ca75
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60e71c11d54b755a3b53eb65
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60e71c48c1bfa3050473b8e5
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60e71c9ad54b755a3b53eb66
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60e71ccb5688f6424c7bfec4
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60e71ce009d7c801eb0c0ec6
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60e71d23c1bfa3050473b8e6
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60e71d6d7fcf9c556f325055
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60e71dc0a94be721b065bbfc
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60e71dc67fcf9c556f325056
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60e71e8ed54b755a3b53eb67
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60e729cf5698ee7b05057439
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _60effd818b669d08a35bfad5
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6113c3586c780c1e710c90bc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6113cc78d3a39d50044c065a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6113cce3d92c473c770200c7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6113d6c3290d254f5e6b27db
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _611a30addbdd8440277441dc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _611a31ce5b7ffe001b4649d1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6123649463849f3d843da7c4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _612368f58b401f4f51239b33
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _612781056f3d944a17348d60
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _612e0cfc8004cc50514c2d9e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _612e0d3767085e45ef14057f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _612e0d81290d254f5e6b291a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _612e0e04568c120fdd294258
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _612e0e3c290d254f5e6b291d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _612e0e55a112697a4b3a66e7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6130c3dffaa1272e43151c7d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6130c43c67085e45ef1405a1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6130c4d51cb55961fa0fd49f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6130ca3fd92c473c77020dbd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _613708a7f8333a5d15594368
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _614451b71e5874611e2c7ae5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _615d8d878004cc50514c3233
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _615d8da4d3a39d50044c10e8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _615d8dbd290d254f5e6b2ed6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _615d8df08004cc50514c3236
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _615d8e2f1cb55961fa0fd9a4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _615d8e9867085e45ef1409c6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _615d8eb350224f204c1da1cf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _615d8f5dd92c473c770212ef
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _615d8f8567085e45ef1409ca
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _615d8faecabb9b7ad90f4d5d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _615d8fd3290d254f5e6b2edc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61605d88ffa6e502ac5e7eeb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61605e13ffa6e502ac5e7eef
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _616442e4faa1272e43152193
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _616554fe50224f204c1da2aa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61657230d92c473c770213d7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _616584766ef05c2ce828ef57
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61659f79d92c473c770213ee
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6165ac306ef05c2ce828ef74
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6165ac8c290d254f5e6b2f6c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6165adcdd3a39d50044c120f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6165aeedfaa1272e431521e3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61695095d92c473c7702147a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61702be9faa1272e431522c3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61702d8a67085e45ef140b24
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public int ShortName { get; set; }
        }

        public class _61702f1b67085e45ef140b26
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public int ShortName { get; set; }
        }

        public class _61703001d92c473c77021497
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61712eae6c780c1e710c9a1d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _617130016c780c1e710c9a24
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _617131a4568c120fdd29482d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61713308d92c473c770214a0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6171367e1cb55961fa0fdb36
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61713a8fd92c473c770214a4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61713cc4d8e3106d9806c109
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6171407e50224f204c1da3c5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61714b2467085e45ef140b2c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61714eec290d254f5e6b2ffc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _617151c1d92c473c770214ab
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _617153016c780c1e710c9a2f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _617154aa1cb55961fa0fdb3b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _617155ee50224f204c1da3cd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61715e7e67085e45ef140b33
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6176a40f0b8c0312ac75a3d3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6176a48d732a664031271438
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6176aca650224f204c1da3fb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6179ac7511973d018217d0b9
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6179acbdc760af5ad2053585
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6179ad0a6e9dd54ac275e3f2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6179ad56c760af5ad2053587
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6179ad74bca27a099552e03a
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6179afd0bca27a099552e040
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6179aff8f57fb279792c60a1
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6179b3a12153c15e937d52bc
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6179b3bdc7560e13d23eeb8d
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6179b4d1bca27a099552e04e
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6179b4f16e9dd54ac275e407
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6179b5b06e9dd54ac275e409
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _6179b5eabca27a099552e052
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _617aa4dd8166f034d57de9c5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _617fd91e5539a84ec44ce155
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61816734d8e3106d9806c1f3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618167441cb55961fa0fdc71
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618167528004cc50514c34f9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618167616ef05c2ce828f1a8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6181688c6c780c1e710c9b04
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618168b350224f204c1da4d8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618168dc8004cc50514c34fc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61816df1d3a39d50044c139e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61816dfa6ef05c2ce828f1ad
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61816fcad92c473c770215cc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61817865d3a39d50044c13a4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618178aa1cb55961fa0fdc80
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61825d06d92c473c770215de
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61825d136ef05c2ce828f1cc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61825d24d3a39d50044c13af
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6183afd850224f204c1da514
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6183b0711cb55961fa0fdcad
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6183b084a112697a4b3a6e6c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6183d53f1cb55961fa0fdcda
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6183fc15d3a39d50044c13e9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6183fd911cb55961fa0fdce9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6183fd9e8004cc50514c358f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618405198004cc50514c3594
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6184055050224f204c1da540
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618407a850224f204c1da549
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61840bedd92c473c77021635
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61840d85568c120fdd2962a5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618426d96c780c1e710c9b9f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618428466ef05c2ce828f218
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618a431df1eb8e24b8741deb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618a5d5852ecee1505530b2a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618a75c9a3884f56c957ca1b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618a75f0bd321d49084cd399
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618a760e526131765025aae3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618aae5a4dc2d41d5c30264b
        {
            public string Name { get; set; }
        }

        public class _618aaeb931ddad66c15eb7e9
        {
            public string Name { get; set; }
        }

        public class _618aaf656bbeff39ad4acf0c
        {
            public string Name { get; set; }
        }

        public class _618aafe23c1dcf601e0327db
        {
            public string Name { get; set; }
        }

        public class _618ab00ef236914bab050ca0
        {
            public string Name { get; set; }
        }

        public class _618ab04934aa2e47480fba2b
        {
            public string Name { get; set; }
        }

        public class _618ab08919394179c84fa57c
        {
            public string Name { get; set; }
        }

        public class _618ab0c66bbeff39ad4acf2e
        {
            public string Name { get; set; }
        }

        public class _618aef6d0a5a59657e5f55ee
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618b9643526131765025ab35
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618b9671d14d6d5ab879c5ea
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618b9682a3884f56c957ca78
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618ba27d9008e4636a67f61d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618ba91477b82356f91ae0e8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618ba92152ecee1505530bd3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618bab21526131765025ab3f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618bb76513f5097c8d5aa2d5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _618cfae774bb2d036a049e7c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61904c9df62c89219a56e034
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61904daa7d0d857927447b9c
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _619252352be33f26043400a7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619256e5f8af2c1a4e1f5d92
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619268ad78f4fa33f173dbe5
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619268de2be33f2604340159
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6193850f60b34236ee0483de
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _619386379fb0c665d5490dbe
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6193a720f8ee7e52e42109ed
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6193d3149fb0c665d5490e32
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6193d338de3cdf1d2614a6fc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6193d382ed0429009f543e65
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6193d3be7c6c7b169525f0da
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6193d3cded0429009f543e6a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6193d5d4f8ee7e52e4210a1b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6193dcd0f8ee7e52e4210a28
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6193e108c1982475fa2a7f16
        {
            public string Name { get; set; }
        }

        public class _6193e18de693542ea37d11b3
        {
            public string Name { get; set; }
        }

        public class _6193e226449ec003d9127fa6
        {
            public string Name { get; set; }
        }

        public class _6193e380069d61205d490dc7
        {
            public string Name { get; set; }
        }

        public class _6193e4a46bb904059c382295
        {
            public string Name { get; set; }
        }

        public class _6193e4fae693542ea37d11c6
        {
            public string Name { get; set; }
        }

        public class _6193e590069d61205d490dd8
        {
            public string Name { get; set; }
        }

        public class _6193e5f3aa34a3034236bdb3
        {
            public string Name { get; set; }
        }

        public class _6194ef39de3cdf1d2614a768
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6194efe07c6c7b169525f11b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6194eff92d2c397d6600348b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6194f017ed0429009f543eaa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6194f02d9bb3d20b0946d2f0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6194f1f918a3974e5e7421e4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6194f2912d2c397d6600348d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6194f2df645b5d229654ad77
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6194f3286db0f2477964e67d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6194f35c18a3974e5e7421e6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6194f41f9fb0c665d5490e75
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6194f5722d2c397d6600348f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6194f5a318a3974e5e7421eb
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6194f5d418a3974e5e7421ef
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61958c366726521dd96828ec
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _619621a4de3cdf1d2614a7a7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619624b26db0f2477964e6b0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6196255558ef8c428c287d1c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61962b617c6c7b169525f168
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _61962d879bb3d20b0946d385
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _6196364158ef8c428c287d9f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _6196365d58ef8c428c287da1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _619636be6db0f2477964e710
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
            public string casingName { get; set; }
        }

        public class _61963a852d2c397d660036ad
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61965d9058ef8c428c287e0d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619666f4af1f5202c57a952d
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6197b229af1f5202c57a9bea
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _6197d1f3585c515a052ad88f
        {
            public string Name { get; set; }
        }

        public class _6198e2ddef80673cae5d1c87
        {
            public string Name { get; set; }
        }

        public class _619b5db699fb192e7430664f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619b69037b9de8162902673e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619b99ad604fcc392676806c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619b99d2d8ed4b751d2606c1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619bc61e86e01e16f839a999
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619bdd8886e01e16f839a99c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619bddc6c9546643a67df6ee
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619bddffc9546643a67df6f0
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619bde3dc9546643a67df6f2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619bde7fc9546643a67df6f4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619bdeb986e01e16f839a99e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619bdef8c9546643a67df6f6
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619bdf9cc9546643a67df6f8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619bdfd4c9546643a67df6fa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619bf75264927e572d0d5853
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619bf78a64927e572d0d5855
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619cbf476b8a1b37a54eebf8
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619cbf7d23893217ec30b689
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619cbf9e0a7c3a1a2731940a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619cbfccbedcde2f5b3f7bdd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619cbfeb6b8a1b37a54eebfa
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619cc01e0a7c3a1a2731940c
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619cf0335771dd3c390269ae
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619d267f36b5be1f3236f9ba
        {
            public string Name { get; set; }
        }

        public class _619d26ccc7791e3af27ae3cd
        {
            public string Name { get; set; }
        }

        public class _619d270836b5be1f3236f9c5
        {
            public string Name { get; set; }
        }

        public class _619d272b0f9e4513744e7699
        {
            public string Name { get; set; }
        }

        public class _619d276ca4712949ff3159b9
        {
            public string Name { get; set; }
        }

        public class _619d36da53b4d42ee724fae4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619e61e70459e93c12392ba7
        {
            public string Name { get; set; }
        }

        public class _619f89ca8858a474c8685cae
        {
            public string Name { get; set; }
        }

        public class _619f89e4737c51579f7cf28b
        {
            public string Name { get; set; }
        }

        public class _619f8a13522d4a788638760c
        {
            public string Name { get; set; }
        }

        public class _619f8a5a7ab73a23bd05f3b5
        {
            public string Name { get; set; }
        }

        public class _619f8a94cc87740b492fc9cf
        {
            public string Name { get; set; }
        }

        public class _619f8ad2522d4a7886387621
        {
            public string Name { get; set; }
        }

        public class _619f8ae93900cb42d25a1ba5
        {
            public string Name { get; set; }
        }

        public class _619f8b0ab90286142b59d412
        {
            public string Name { get; set; }
        }

        public class _619f8ba3cc87740b492fc9e3
        {
            public string Name { get; set; }
        }

        public class _619f8bddb90286142b59d427
        {
            public string Name { get; set; }
        }

        public class _619f94f5b90286142b59d45f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _619f9e338858a474c8685cc9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61a00bcb177fb945751bbe6a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61a49f549128666d8302b5f1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61a4a06dba63c0388e05613e
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61a4a138ba63c0388e056140
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61a4a1c59128666d8302b5f3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61a64428a8c6aa1b795f0ba1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61a6444b8c141d68246e2d2f
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61a64492ba05ef10d62adcc1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61a89e5445a2672acf66c877
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61aa1e9a32a4743c3453d2cf
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61aa1ead84ea0800645777fd
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61aa5aed32a4743c3453d319
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61aa5b518f5e7a39b41416e2
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61aa5b7db225ac1ead7957c1
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61aa5ba8018e9821b7368da9
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61aa81fcb225ac1ead7957c3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61b0a9765e235838646d94d9
        {
            public string Name { get; set; }
        }

        public class _61b9e1aaef9a1b5d6a79899a
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61bb468b8d7cac1532300ccc
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _61bb47481908c67d4249a205
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _61bb474b1ab5304c3817a53a
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _61bb474dce7374453b45dfd2
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _61bb474f8b8d2a79d012cd6e
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _61bb47516b70332c062ca7b9
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _61bb475467f83663e155e26a
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _61bb4756883b2c16a163870a
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _61bb47578d7cac1532300ccd
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _61bc85697113f767765c7fe7
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _61bca7cda0eae612383adf57
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61bcc89aef0f505f0c6cd0fc
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string RigLayoutName { get; set; }
            public string ShortName { get; set; }
        }

        public class _61bf7b6302b3924be92fa8c3
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61bf7c024770ee6f9c6b8b53
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61bf83814088ec1a363d7097
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61bfa784f4378605ca5598e1
        {
            public Conditions conditions { get; set; }
            public string description { get; set; }
            public string failMessageText { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string note { get; set; }
            public string startedMessageText { get; set; }
            public string successMessageText { get; set; }
        }

        public class _61c18d83b00456371a66814b
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class _61c18db6dfd64163ea78fbb4
        {
            public string Description { get; set; }
            public string Name { get; set; }
            public string ShortName { get; set; }
        }

        public class Banners
        {
            public _5464e0404bdc2d2a708b4567 _5464e0404bdc2d2a708b4567 { get; set; }
            public _5464e0454bdc2d06708b4567 _5464e0454bdc2d06708b4567 { get; set; }
            public _5803a58524597710ca36fcb2 _5803a58524597710ca36fcb2 { get; set; }
            public _5805f617245977100b2c1f41 _5805f617245977100b2c1f41 { get; set; }
            public _5807be8924597742c603fa19 _5807be8924597742c603fa19 { get; set; }
            public _5807bfe124597742a92e0a4c _5807bfe124597742a92e0a4c { get; set; }
            public _5807c3f124597746bf2db2ce _5807c3f124597746bf2db2ce { get; set; }
            public _5c1b857086f77465f465faa4 _5c1b857086f77465f465faa4 { get; set; }
        }

        public class Conditions
        {
            public string _5967379186f77463860dadd6 { get; set; }
            public string _596737cb86f77463a8115efd { get; set; }
            public string _59689eb886f7740d137ebfc3 { get; set; }
            public string _5968edc086f77420d2328014 { get; set; }
            public string _5ae452c086f774336a397578 { get; set; }
            public string _5ae452de86f77450595c4333 { get; set; }
            public string _5ae452fa86f774336a39758e { get; set; }
            public string _5ae4531986f774177033c3e6 { get; set; }
            public string _5b50761b88a4507f45121125 { get; set; }
            public string _5ae4543686f7742dc043c903 { get; set; }
            public string _5ae454a086f7742be909a81a { get; set; }
            public string _5af4157f86f7745f696ebd3d { get; set; }
            public string _5fd89729a8c881276c560433 { get; set; }
            public string _5fd89799c54dc00f463272d3 { get; set; }
            public string _5ae9b32486f7745bbc72275a { get; set; }
            public string _5ae9b34686f7743129512ccf { get; set; }
            public string _5ae9b36c86f774307c29df04 { get; set; }
            public string _5ae9b38a86f77432c81e2ce3 { get; set; }
            public string _5ae9b3b186f7745bbc722762 { get; set; }
            public string _5ae9b3c986f77432c81e2ce6 { get; set; }
            public string _5af415b286f77407184495dd { get; set; }
            public string _5ae9b5bd86f774307c29df37 { get; set; }
            public string _5ae9b63286f774229110402d { get; set; }
            public string _5af415c386f7745c267423a7 { get; set; }
            public string _5ae4559386f7742dc043c95e { get; set; }
            public string _5ae455be86f7742dc043c969 { get; set; }
            public string _5ae455fb86f7744dd8242380 { get; set; }
            public string _5ae4562086f774498b05e0dc { get; set; }
            public string _5af415f486f7745bf73dad59 { get; set; }
            public string _5af4201386f774267375038c { get; set; }
            public string _5ae9b77f86f77432c81e3074 { get; set; }
            public string _5ae9b7c886f774307c29df56 { get; set; }
            public string _5ae9b91386f77415a869b3f3 { get; set; }
            public string _5ae9b93b86f7746e0026221a { get; set; }
            public string _5af4165d86f7745bf73dad72 { get; set; }
            public string _5ae9bb6986f77415a869b40b { get; set; }
            public string _5ae9bc6e86f7746e0026222c { get; set; }
            public string _5ae9be7f86f7746c6337153d { get; set; }
            public string _5ae9bea886f77468ab400e64 { get; set; }
            public string _5ae45d7786f774178f237745 { get; set; }
            public string _5ae45d9386f774178f23774a { get; set; }
            public string _5af079e486f77434693ad7f8 { get; set; }
            public string _5af07a0286f7747dba10d8ac { get; set; }
            public string _5af4168d86f7745c267423dc { get; set; }
            public string _5ae9c0a686f774703201f143 { get; set; }
            public string _5ae9c0c986f77468ab400f88 { get; set; }
            public string _5ae9c0e186f7746419683c5e { get; set; }
            public string _5ae9c10686f774703201f146 { get; set; }
            public string _5af416f086f7745c524a375f { get; set; }
            public string _5af4192c86f774297e641027 { get; set; }
            public string _5ae9c29386f77427153c7fb0 { get; set; }
            public string _5af4170e86f7745c267423e9 { get; set; }
            public string _5af4171686f7741c8f21cb9e { get; set; }
            public string _59689f7586f7740d14064726 { get; set; }
            public string _5a3fc0ff86f7744d9c2eff86 { get; set; }
            public string _5ca6026286f77446d87abec3 { get; set; }
            public string _5cb6f32986f7746ef55e17a0 { get; set; }
            public string _5ae9c38e86f7743515398707 { get; set; }
            public string _5af4172f86f774059056f692 { get; set; }
            public string _5ae9e0dd86f77443f2500fd4 { get; set; }
            public string _5ae9e17c86f77440d37ce03c { get; set; }
            public string _5ae9e1c786f77403fb3f9674 { get; set; }
            public string _5ae9e2a286f7740de4152a0a { get; set; }
            public string _5ae9e2e386f7740de4152a0d { get; set; }
            public string _5af4177686f77406f92eee62 { get; set; }
            public string _5af4178e86f77426757cb152 { get; set; }
            public string _5af417c086f7742a2712c3c2 { get; set; }
            public string _5af4196886f7742a2627a4be { get; set; }
            public string _5bb60cbc88a45011a8235cc5 { get; set; }
            public string _5ae9e55886f77445315f662a { get; set; }
            public string _5ae9e58886f77423572433f5 { get; set; }
            public string _5af417e386f77428ae313af3 { get; set; }
            public string _5af4181286f77428bb55edd9 { get; set; }
            public string _5af4186c86f77428ae313afa { get; set; }
            public string _5b47796686f774374f4a8bb1 { get; set; }
            public string _5b4f082f86f7747a284dd609 { get; set; }
            public string _5b4f0cc186f7744def7f3389 { get; set; }
            public string _5b477b3b86f77401da02e6c4 { get; set; }
            public string _5b4f085586f7747a2910a9b2 { get; set; }
            public string _5b4f0d6086f7742c1f5a3c4d { get; set; }
            public string _5b477f1486f7743009493232 { get; set; }
            public string _5b4f087886f77479806f2c61 { get; set; }
            public string _5b4f0cce86f774287331639a { get; set; }
            public string _5b47824386f7744d190d8dd1 { get; set; }
            public string _5b4f094886f7747b127d9d7f { get; set; }
            public string _5b4f0d7186f77412bc326997 { get; set; }
            public string _5b4783ba86f7744d1c353185 { get; set; }
            public string _5b4f095b86f7747a2637c3f9 { get; set; }
            public string _5b4f0ce686f77429c16dcb63 { get; set; }
            public string _5b47884886f7744d1c35327d { get; set; }
            public string _5b47886986f7744d1a393e65 { get; set; }
            public string _5b4f09c786f77479806f2cf3 { get; set; }
            public string _5b4f09f586f7744fba15b2dc { get; set; }
            public string _5b4f0c7b86f77479ee584ab0 { get; set; }
            public string _5968a06486f7740d14064728 { get; set; }
            public string _5a3fb73b86f77458e0324376 { get; set; }
            public string _5b47899386f77470315db7f3 { get; set; }
            public string _5b4789b586f7744d190d8f43 { get; set; }
            public string _5b4789df86f77468074619d7 { get; set; }
            public string _5b478a0986f7744d190d8f46 { get; set; }
            public string _5b478a2186f77468074619da { get; set; }
            public string _5b478a3786f77470315db7fa { get; set; }
            public string _5b478a6c86f7744d190d8f4d { get; set; }
            public string _5b478a8486f7744d1c35328b { get; set; }
            public string _5b4f0a4386f7744e1155e1ed { get; set; }
            public string _5b4f0a5086f7744e3a6b328a { get; set; }
            public string _5b4f0c8786f77479806f3028 { get; set; }
            public string _5b478c4c86f7744d1a393fac { get; set; }
            public string _5b478c7386f7744d1a393fb1 { get; set; }
            public string _5b478cb586f7744d1a393fb5 { get; set; }
            public string _5b4f0a8086f7744e3a6b3290 { get; set; }
            public string _5b4f0c9086f77453572f5538 { get; set; }
            public string _5b478d8986f774563c7a4809 { get; set; }
            public string _5b478daf86f7744d1c35339b { get; set; }
            public string _5b478dca86f7744d190d91c2 { get; set; }
            public string _5b478de086f7744d1c3533a1 { get; set; }
            public string _5b4f0ac386f7747a2637c4c0 { get; set; }
            public string _5b4f0c9d86f7744def7f3385 { get; set; }
            public string _5b478f6886f774464201225a { get; set; }
            public string _5b478f8886f7744d1b23c622 { get; set; }
            public string _5b4c826b86f7743cc87bcee4 { get; set; }
            public string _5b4c82cd86f774170c6e4169 { get; set; }
            public string _5b4c832686f77419603eb8f0 { get; set; }
            public string _5b4c836486f77417063a09dc { get; set; }
            public string _5b4f0b8b86f7747a2910aaa4 { get; set; }
            public string _5b4f0c1486f7747a2637c513 { get; set; }
            public string _5b47905886f7746807461fe2 { get; set; }
            public string _5b4790a886f774563c7a489f { get; set; }
            public string _5b4f0b1f86f7746c9e27e9ea { get; set; }
            public string _5cb5ffd986f7746ef55de2c7 { get; set; }
            public string _5ec1388d83b69d213d3c2ee0 { get; set; }
            public string _5b47932586f7747cc908b5dd { get; set; }
            public string _5b47936686f77427fd044025 { get; set; }
            public string _5b47938086f7747ccc057c22 { get; set; }
            public string _5b4f0b6686f77479ee584a74 { get; set; }
            public string _5b4f0c0986f77453572f54e0 { get; set; }
            public string _5b47952c86f774598100d5dc { get; set; }
            public string _5b47958e86f774598100d5e2 { get; set; }
            public string _5b4795a586f774587a39506d { get; set; }
            public string _5b4c742886f7745cef1d02f5 { get; set; }
            public string _5b4c75a786f7747332534b52 { get; set; }
            public string _5b4c764786f7746f3b494ee0 { get; set; }
            public string _5b4c769686f7746e535a5c0e { get; set; }
            public string _5b4c76d886f77471d31735a3 { get; set; }
            public string _5b4c7aec86f77459732b4b08 { get; set; }
            public string _5b4c8e6586f77474396a5400 { get; set; }
            public string _5b4f0bca86f7744a6c2b8164 { get; set; }
            public string _5b4f0bfa86f77453572f54dc { get; set; }
            public string _5b47968e86f7745877352c28 { get; set; }
            public string _5b4796c086f7745877352c2c { get; set; }
            public string _5b47971086f774587877ad34 { get; set; }
            public string _5b4f0ba486f7747a2637c4fb { get; set; }
            public string _5b4f0c5886f7747a2910aacd { get; set; }
            public string _5c923d3d86f774556e08d7a5 { get; set; }
            public string _5bc850d186f7747213700892 { get; set; }
            public string _5bdac2f186f7743e152e8695 { get; set; }
            public string _5bd983d886f7747ba73fc246 { get; set; }
            public string _5bd9842e86f7747baa07aba7 { get; set; }
            public string _5bd9944f86f774035c4877f3 { get; set; }
            public string _5bdabf0586f7743e1809c555 { get; set; }
            public string _5968eb9b86f7741ddb481543 { get; set; }
            public string _5bc47e3e86f7741e6b2f3332 { get; set; }
            public string _5bdabf1f86f7743e1809c556 { get; set; }
            public string _5bc4813886f774226045cb9a { get; set; }
            public string _5bdabf3386f7743e171249ae { get; set; }
            public string _5bc84f7a86f774294c2f6862 { get; set; }
            public string _5bdabf4486f7743e1665df6d { get; set; }
            public string _5bc483ba86f77415034ba8d0 { get; set; }
            public string _5bdabf5386f7743e152e867c { get; set; }
            public string _5bc485b586f774726473a858 { get; set; }
            public string _5bdabf6286f7743e171249af { get; set; }
            public string _5bc48aed86f77452c947ce67 { get; set; }
            public string _5bdabf7186f7743e152e867d { get; set; }
            public string _5c0bc32986f7743e4d1002d2 { get; set; }
            public string _5c0bc43e86f7744794440ba5 { get; set; }
            public string _5c12320586f77437e44bcb15 { get; set; }
            public string _5c1233ac86f77406fa13baea { get; set; }
            public string _5c17b96486f774331c793f28 { get; set; }
            public string _5c1fa91586f7740de474cb36 { get; set; }
            public string _5c50481c86f77410650e0521 { get; set; }
            public string _5c0bc95086f7746e784f39ec { get; set; }
            public string _5c0bcc9c86f7746fe16dbba9 { get; set; }
            public string _5c1ea18b86f77461d75caa21 { get; set; }
            public string _5c1fa99086f77407e903a5fa { get; set; }
            public string _5c1242fa86f7742aa04fed52 { get; set; }
            public string _5c17d05e86f77430a64c6c66 { get; set; }
            public string _5c20cd8f86f774337d77b7ef { get; set; }
            public string _5c1b765d86f77413193fa4f2 { get; set; }
            public string _5c1fabb986f77431f74f0de6 { get; set; }
            public string _5c1fabd686f77410894b63f8 { get; set; }
            public string _5969f98286f774576d4c9542 { get; set; }
            public string _5969f99286f77456630ea442 { get; set; }
            public string _596a212e86f774576d4c95df { get; set; }
            public string _5c0bdbb586f774166e38eed5 { get; set; }
            public string _5c1faac086f7740ebd348c76 { get; set; }
            public string _5c1faac986f77410894b63f5 { get; set; }
            public string _5c0bdf2c86f7746f016734a8 { get; set; }
            public string _5c137b8886f7747ae3220ff4 { get; set; }
            public string _5c137ef386f7747ae10a821e { get; set; }
            public string _5c137f5286f7747ae267d8a3 { get; set; }
            public string _5c20007986f7743c7b263515 { get; set; }
            public string _5c20009b86f7742b3c0a8fd9 { get; set; }
            public string _5c0be2b486f7747bcb347d58 { get; set; }
            public string _5c1fb5f086f7744a184fb3c5 { get; set; }
            public string _5c1fb5f986f7744a1929a527 { get; set; }
            public string _5c0be66c86f7744523489ab2 { get; set; }
            public string _5c0be69086f7743c9c1ecf43 { get; set; }
            public string _5c1fd1ae86f7742b3b47f064 { get; set; }
            public string _5c1fd1b586f7742b3a651f74 { get; set; }
            public string _5fd892bc37b6e511a4734969 { get; set; }
            public string _5fd8935b7dd32f724e0fe7ee { get; set; }
            public string _5c0d0dfd86f7747f482a89a5 { get; set; }
            public string _5c1fd5e586f7743c7b261f79 { get; set; }
            public string _5c1fd5f586f7742b391bf138 { get; set; }
            public string _5c138c4486f7743b056e2943 { get; set; }
            public string _5c138d4286f774276a6504aa { get; set; }
            public string _5c1fd61486f7742b391bf139 { get; set; }
            public string _5c1fd61e86f7742b38529146 { get; set; }
            public string _5ec13d45a1032866196c939b { get; set; }
            public string _5ec13da983b69d213d3c2ee4 { get; set; }
            public string _5c1b760686f77412780211a3 { get; set; }
            public string _5c1fab3986f7740ebd348c7a { get; set; }
            public string _5c1fab4186f77431f74f0de5 { get; set; }
            public string _5c1b778286f774294438b536 { get; set; }
            public string _5c1fd52e86f7742b391bf099 { get; set; }
            public string _5c1fd53a86f7742b3c0a7b7a { get; set; }
            public string _5c1b713486f77413bc250406 { get; set; }
            public string _5c1b713986f77470d8650910 { get; set; }
            public string _5c1b713f86f774719c22e8a0 { get; set; }
            public string _5c1fd66286f7743c7b261f7b { get; set; }
            public string _5c20ce1786f77453c56d6397 { get; set; }
            public string _5c20ce2c86f774337f427599 { get; set; }
            public string _5c0d4f46d09282029f539216 { get; set; }
            public string _5c0e6876d09282029e2fffe0 { get; set; }
            public string _5c0e687ad0928202b25db840 { get; set; }
            public string _5c13979886f774251443c1a6 { get; set; }
            public string _5c13982286f774365a69cc4d { get; set; }
            public string _5c13989886f7747878361a50 { get; set; }
            public string _5c1931e686f7747ce71bcbea { get; set; }
            public string _5d0a0e2286f7743a1a74d63b { get; set; }
            public string _5d0a111586f7743a1b0d87b1 { get; set; }
            public string _5dc984ae4b68b15f4825cea5 { get; set; }
            public string _5969fa4886f7741ddb481544 { get; set; }
            public string _5969fa8986f7741ddc2d3154 { get; set; }
            public string _5a3fb8f686f7742384533f10 { get; set; }
            public string _5a3fb92286f77422b46cdb18 { get; set; }
            public string _5c10f94386f774227172c574 { get; set; }
            public string _5c10f94386f774227172c575 { get; set; }
            public string _5c10f94386f774227172c576 { get; set; }
            public string _5c10f94386f774227172c577 { get; set; }
            public string _5c1fb27e86f7744a160dda8c { get; set; }
            public string _5c1fcf9486f7742b3b47e370 { get; set; }
            public string _5c1129ed86f7746569440e88 { get; set; }
            public string _5c112a1b86f774656777d1ae { get; set; }
            public string _5c1fb45b86f7744a1a275659 { get; set; }
            public string _5c1fb46386f7744a184fb3c2 { get; set; }
            public string _5ca719ef86f7740a78020783 { get; set; }
            public string _5ca71a1e86f7740f5a5b88a2 { get; set; }
            public string _5c112dc486f77465686bff38 { get; set; }
            public string _5c1fd15f86f7742b3c0a7b78 { get; set; }
            public string _5c1fd17786f7742b3b47f063 { get; set; }
            public string _5c11427386f77430ff393793 { get; set; }
            public string _5c122c5f86f77437e44bcb0e { get; set; }
            public string _5c1fd03686f7742b3c0a6a9f { get; set; }
            public string _5c1fd04886f7742b3b47e8a2 { get; set; }
            public string _5ca7254e86f7740d424a2043 { get; set; }
            public string _5ca7258986f7740d424a2044 { get; set; }
            public string _5c1fa9c986f7740de474cb3d { get; set; }
            public string _5c1faa0d86f77410894b63ef { get; set; }
            public string _5c1faa1986f7740ebd348c71 { get; set; }
            public string _5c12470d86f77465ae27a8c0 { get; set; }
            public string _5c1247f386f77452db1d2b03 { get; set; }
            public string _5c12484586f7744b83469074 { get; set; }
            public string _5c12487386f7742a60324299 { get; set; }
            public string _5c12489886f77452db1d2b05 { get; set; }
            public string _5c1248ef86f77428266184c2 { get; set; }
            public string _5c1fab8686f77410894b63f7 { get; set; }
            public string _5c1fab9286f77407e903a60d { get; set; }
            public string _5c139eb686f7747878361a72 { get; set; }
            public string _5c139eb686f7747878361a73 { get; set; }
            public string _5c1fcf3786f7742b3b47e36f { get; set; }
            public string _5c1fcf4086f7742b38527bde { get; set; }
            public string _5ec14003e16f6c41ee73525f { get; set; }
            public string _5ec14080c9ffe55cca300867 { get; set; }
            public string _5c51aea486f774423e5e36e3 { get; set; }
            public string _5c51aebf86f774423b4767d2 { get; set; }
            public string _5c51aee886f774423d3f9072 { get; set; }
            public string _5c51af6586f774423b4767d3 { get; set; }
            public string _5c51af7086f774423d3f9073 { get; set; }
            public string _5c51afd786f774423e5e36e5 { get; set; }
            public string _5c51affc86f774423b4767d4 { get; set; }
            public string _5c51bed886f77478bb033461 { get; set; }
            public string _5c51bf8786f77416a11e5cb2 { get; set; }
            public string _5c51bf9a86f77478bf5632aa { get; set; }
            public string _5c51bfb186f77478bd516d37 { get; set; }
            public string _5c51bfc286f77478bc7ae1d9 { get; set; }
            public string _5c51c03186f7740ada3f2c3d { get; set; }
            public string _5c51c04286f77478be4009f5 { get; set; }
            public string _5c51c23a86f77478bb033466 { get; set; }
            public string _5c51c24c86f77416a11e5cb7 { get; set; }
            public string _5c51c25c86f77478bf5632af { get; set; }
            public string _5c51db2a86f77478be4009ff { get; set; }
            public string _5c52b92e86f77478be400a00 { get; set; }
            public string _5c52bb0586f774119c51f7f2 { get; set; }
            public string _5c52bb6486f774119d57d3c2 { get; set; }
            public string _5c52bb9586f774119f65fea2 { get; set; }
            public string _5c52bbad86f774119c51f7f3 { get; set; }
            public string _5c52bbb786f774119e65e722 { get; set; }
            public string _5c52bbc086f77411a04c2c72 { get; set; }
            public string _5c52bbde86f774119d57d3c3 { get; set; }
            public string _5c52bbe986f774119f65fea3 { get; set; }
            public string _5c52c3a486f7745e2760c5c2 { get; set; }
            public string _5c52c3cf86f774119d57d3c4 { get; set; }
            public string _5c52c3e386f774119f65fea4 { get; set; }
            public string _5c52c4f386f7745e2760c5c3 { get; set; }
            public string _5c52c50686f774119d57d3c5 { get; set; }
            public string _5c52c51786f774119f65fea5 { get; set; }
            public string _5c52c53286f7745e2760c5c4 { get; set; }
            public string _5c52c54586f774119d57d3c6 { get; set; }
            public string _5c52c55486f774119f65fea6 { get; set; }
            public string _5c52c58c86f774119f65fea7 { get; set; }
            public string _5c52c59986f7745e2760c5c5 { get; set; }
            public string _5c52c5a586f774119d57d3c7 { get; set; }
            public string _5c52c5ce86f774119f65fea8 { get; set; }
            public string _5c52c5e386f7745e2760c5c6 { get; set; }
            public string _5c52c5f686f774119d57d3c8 { get; set; }
            public string _5c52c60d86f774119f65fea9 { get; set; }
            public string _5c52c6f986f77411a04c2c73 { get; set; }
            public string _5c52c77386f774119c51f7f4 { get; set; }
            public string _5c52c78986f774119e65e723 { get; set; }
            public string _5c52c7d286f77411a04c2c74 { get; set; }
            public string _5c52c7e786f774119c51f7f5 { get; set; }
            public string _5c52c8b086f774119e65e724 { get; set; }
            public string _5c52c96586f7745e2760c5c8 { get; set; }
            public string _5c52c9b186f774119d57d3c9 { get; set; }
            public string _5c52c9e786f774119f65feaa { get; set; }
            public string _5c52ca1286f7745e2760c5c9 { get; set; }
            public string _5c52ca2286f774119d57d3ca { get; set; }
            public string _5c52ca2e86f774119f65feab { get; set; }
            public string _5c52ca5b86f774119e65e725 { get; set; }
            public string _5c52ca6e86f77411a04c2c75 { get; set; }
            public string _5c52ca7c86f774119c51f7f6 { get; set; }
            public string _5c52ca9786f774119e65e726 { get; set; }
            public string _5c52caae86f77411a04c2c76 { get; set; }
            public string _5c52ccdb86f774469a2cf962 { get; set; }
            public string _5c52ccfb86f774469c210932 { get; set; }
            public string _5c52cd0f86f77446992b9172 { get; set; }
            public string _5c52cd2086f774469b529d72 { get; set; }
            public string _5c52cd3386f774469d73a592 { get; set; }
            public string _5c52ce5486f7742fba438c52 { get; set; }
            public string _5c52ce6786f7742fb77f6b12 { get; set; }
            public string _5c52da1086f7742fbb42a814 { get; set; }
            public string _5c52da5886f7747364267a14 { get; set; }
            public string _5cb5ddd386f7746ef72a7e73 { get; set; }
            public string _5cb5dde786f7746ef451bd74 { get; set; }
            public string _5cb5de0086f7746ef82c17e4 { get; set; }
            public string _5cb5de1786f7747d215eca04 { get; set; }
            public string _5cb5de9c86f7746ef55dbc86 { get; set; }
            public string _5cb5deae86f7746ef451bd76 { get; set; }
            public string _5cb5debf86f7746ef72a7e78 { get; set; }
            public string _5cb5ded886f7746ef451bd77 { get; set; }
            public string _5cb5dee986f7746ef82c17e7 { get; set; }
            public string _5cb5df5586f7746ef82c17e8 { get; set; }
            public string _5cb5df7186f7747d215eca08 { get; set; }
            public string _5cb5df8486f7746ef82c17ea { get; set; }
            public string _5db9aaf46194ab4e69304de8 { get; set; }
            public string _5de798b233870205123c7f33 { get; set; }
            public string _5ec798b8254c431289542b90 { get; set; }
            public string _5ec7998dc1683c0db84484e7 { get; set; }
            public string _5ec79aaac1683c0db84484e8 { get; set; }
            public string _5ec79b3ced84ad5ddb58e24c { get; set; }
            public string _5ec79c2fed84ad5ddb58e24d { get; set; }
            public string _5ec79c5ac1683c0db84484eb { get; set; }
            public string _5ec79f2c82a25876330cb232 { get; set; }
            public string _5ec79fb273279f683254baaa { get; set; }
            public string _5f75d3ab0e3df95a7f52b367 { get; set; }
            public string _5f75d4558f70ca7a1d684dac { get; set; }
            public string _5f75d4e79a479f5c16331352 { get; set; }
            public string _5f75d521edb90b73913272a3 { get; set; }
            public string _60cfa1031bdece56c249cbf4 { get; set; }
            public string _60cfa136f81cc57f471718cb { get; set; }
            public string _60d06de320a6283a506aeb67 { get; set; }
            public string _60d06e921bdece56c249cc0c { get; set; }
            public string _60d06eef41fd1e14d71e2323 { get; set; }
            public string _60d06f3420a6283a506aeb69 { get; set; }
            public string _60d06f8cac6eb02bc726de99 { get; set; }
            public string _60d074211bdece56c249cc13 { get; set; }
            public string _60d0748820a6283a506aebb1 { get; set; }
            public string _60d074ef401d874962160aee { get; set; }
            public string _60d9a73d9f89812e5b6ac368 { get; set; }
            public string _60d9a752ac6eb02bc726fcc6 { get; set; }
            public string _60d9a77141fd1e14d71e2bfc { get; set; }
            public string _60d9a77c646f74055e27750a { get; set; }
            public string _60d9a7955f9e6175514def1b { get; set; }
            public string _60d9a79fac6eb02bc726fcc7 { get; set; }
            public string _60d9a7abf81cc57f47174189 { get; set; }
            public string _60d9a7c7826ca0323464cf23 { get; set; }
            public string _60d9a7cf9f89812e5b6ac369 { get; set; }
            public string _60d9a7dd401d87496216141f { get; set; }
            public string _60d9a80e807141159d0a4e5b { get; set; }
            public string _60d9d34e8a6f9a3731773f93 { get; set; }
            public string _60e827a20c492412897c688e { get; set; }
            public string _60e827faf09904268a4dbc40 { get; set; }
            public string _5d2496fb86f77425ce7f1254 { get; set; }
            public string _5d249a6e86f774791546e952 { get; set; }
            public string _5d249aa286f77475e8376399 { get; set; }
            public string _5d7fc0f386f77440373c4d78 { get; set; }
            public string _5d7fc0fb86f77440351becb3 { get; set; }
            public string _5d24ba7886f77439c92d6baa { get; set; }
            public string _5d24bb4886f77439c92d6bad { get; set; }
            public string _5d24bb7286f7741f7956be74 { get; set; }
            public string _5d76276186f774454c5360bc { get; set; }
            public string _5d77d51c86f7742fa65b6608 { get; set; }
            public string _596a0e7086f7741ddf17dbef { get; set; }
            public string _596a0e8086f7741ddd6c104c { get; set; }
            public string _596a0eaf86f774576d4c957f { get; set; }
            public string _596a113d86f7741ddd6c104d { get; set; }
            public string _5d25af3c86f77443ff46b9e7 { get; set; }
            public string _5d76302d86f774454d58840e { get; set; }
            public string _5d77d4a386f7745041358b56 { get; set; }
            public string _5d25beca86f77409dd5cdbb3 { get; set; }
            public string _5d25beeb86f77443fe45765f { get; set; }
            public string _5d2deedc86f77459121c3118 { get; set; }
            public string _5d2defc586f774591510e6b9 { get; set; }
            public string _5d76307886f774454c5360c1 { get; set; }
            public string _5d77d13e86f77461b27a237a { get; set; }
            public string _5d25c5a186f77443fe457661 { get; set; }
            public string _5d9f035086f7741cac4a9713 { get; set; }
            public string _5dadc98786f7744b0c681e8e { get; set; }
            public string _5dadc99686f7744b0f1b1d2a { get; set; }
            public string _5d25c8c986f77443e47ad47a { get; set; }
            public string _5d7630e286f774452173421a { get; set; }
            public string _5d77d0f286f7742fa65b6604 { get; set; }
            public string _5d25d09286f77444001e284c { get; set; }
            public string _5d25d0d186f7740a22515975 { get; set; }
            public string _5d9c940886f7742cd41c59c0 { get; set; }
            public string _5d9c941f86f7743554286958 { get; set; }
            public string _5d25d4e786f77442734d335d { get; set; }
            public string _5d76322786f774454e50d062 { get; set; }
            public string _5d84afb986f77414e20063ea { get; set; }
            public string _5d25dc2286f77443e7549028 { get; set; }
            public string _5d76332c86f774454e50d063 { get; set; }
            public string _5d77cdc286f7742fa65b6603 { get; set; }
            public string _5d25fd8386f77443fe457cae { get; set; }
            public string _5d77cd9d86f7742fa857dd73 { get; set; }
            public string _5d77cda786f774319c488837 { get; set; }
            public string _5d2605ef86f77469ef0f7622 { get; set; }
            public string _5d76336486f7744527181847 { get; set; }
            public string _5d77cd3d86f7742fa732bf15 { get; set; }
            public string _5d26143c86f77469ef0f894c { get; set; }
            public string _5d763d7c86f774452073df77 { get; set; }
            public string _5d77cc4886f7742fa732bf14 { get; set; }
            public string _596a10d886f7741ddf17dbf0 { get; set; }
            public string _596a117386f7741ddf17dbf1 { get; set; }
            public string _5d26fd8886f77469f0445745 { get; set; }
            public string _5d2710e686f7742e9019a6b2 { get; set; }
            public string _5d66741c86f7744a2e70f039 { get; set; }
            public string _5d77689686f7742fa857dd34 { get; set; }
            public string _5d77c96386f7742fa901bcc7 { get; set; }
            public string _5d2701b586f77469f1599fe2 { get; set; }
            public string _5d7768bf86f774319c488824 { get; set; }
            public string _5d77c8df86f7742fa65b6602 { get; set; }
            public string _5d307fc886f77447f15f5b23 { get; set; }
            public string _5d77695b86f7742fa901bc75 { get; set; }
            public string _5d77c84d86f7742fa901bcc6 { get; set; }
            public string _5d2719b186f7740701348573 { get; set; }
            public string _5d271a3486f774483c7bdb12 { get; set; }
            public string _5d667a8e86f774131e206b46 { get; set; }
            public string _5d776b1986f77461b27a2354 { get; set; }
            public string _5d77c80b86f7742fa65b6601 { get; set; }
            public string _5d27276886f7740701348578 { get; set; }
            public string _5d272a0b86f7745ba2701532 { get; set; }
            public string _5d2f464e498f71c8886f7656 { get; set; }
            public string _5d77c65786f7742fa901bcc5 { get; set; }
            public string _5d77c66586f7742fa732bf13 { get; set; }
            public string _5d272bd386f77446085fa4f9 { get; set; }
            public string _5d776ef786f7742fa5005cb5 { get; set; }
            public string _5d77a48286f77461b27a236b { get; set; }
            public string _5d2733c586f7741dea4f3072 { get; set; }
            public string _5d77710186f774319c488825 { get; set; }
            public string _5d77a45386f774319c488836 { get; set; }
            public string _5d27369586f774457411b264 { get; set; }
            public string _5d777e3a86f7742fa857dd36 { get; set; }
            public string _5d777eb086f7742fa732bf05 { get; set; }
            public string _5d273a4d86f774457411b266 { get; set; }
            public string _5d777f5d86f7742fa901bc77 { get; set; }
            public string _5d777ffd86f774319c488827 { get; set; }
            public string _5d77a3b286f7745041358b44 { get; set; }
            public string _5d27446f86f77475a86565a3 { get; set; }
            public string _5d7782c686f7742fa732bf07 { get; set; }
            public string _5d7782f886f7742fa65b65f5 { get; set; }
            public string _5d77830086f7745041358b35 { get; set; }
            public string _5d77a38e86f7745041358b43 { get; set; }
            public string _5ec1504183b69d213d3c2ee8 { get; set; }
            public string _5ec1538a92e95f77ac7a2529 { get; set; }
            public string _596a1f0486f77456630ea4d2 { get; set; }
            public string _596a1f1586f77420d2328077 { get; set; }
            public string _5d357b6c86f774588d4d7e25 { get; set; }
            public string _5d357b9586f7745b422d653f { get; set; }
            public string _5d357bb786f774588d4d7e27 { get; set; }
            public string _5d7784cc86f7742fa5005cba { get; set; }
            public string _5d77854786f7745041358b36 { get; set; }
            public string _5d77a36086f77461b27a236a { get; set; }
            public string _5d27491686f77475aa5cf5b9 { get; set; }
            public string _5d6949e786f774238a38d9e0 { get; set; }
            public string _5d77a27d86f774319c488835 { get; set; }
            public string _5d77a29b86f7742fa65b6600 { get; set; }
            public string _5d27522686f774304e316405 { get; set; }
            public string _5d357e0e86f7745b3f307c56 { get; set; }
            public string _5d357e8786f7745b5e66a51a { get; set; }
            public string _5d778e6c86f77461b27a235d { get; set; }
            public string _5d778e7c86f7742fa901bc7c { get; set; }
            public string _5d77a24986f7742fa65b65ff { get; set; }
            public string _5d2f375186f7745916404955 { get; set; }
            public string _5d778ebb86f7742fa732bf09 { get; set; }
            public string _5d778ec586f7745041358b37 { get; set; }
            public string _5d778f7d86f7742fa65b65f9 { get; set; }
            public string _5d8a09d386f77410b4225d13 { get; set; }
            public string _5d7793fa86f7742fa901bc80 { get; set; }
            public string _5d77940986f7742fa732bf0a { get; set; }
            public string _5fd8aa3206fb3a6b8154a2c3 { get; set; }
            public string _5d77a16486f77461b27a2369 { get; set; }
            public string _5d77a17386f7742fa901bcc2 { get; set; }
            public string _5d8a05d086f77410b4225d10 { get; set; }
            public string _5d4bfe4b86f7744a9d4fe032 { get; set; }
            public string _5d4bfe7c86f7744a9c66b316 { get; set; }
            public string _5d4c020a86f77449c463ced6 { get; set; }
            public string _5d4c028c86f774389001e027 { get; set; }
            public string _5d761f6886f7744521734218 { get; set; }
            public string _5d77db2186f7745041358b57 { get; set; }
            public string _5d6fb8a886f77449db3db8b6 { get; set; }
            public string _5d77c61786f7742fa732bf12 { get; set; }
            public string _5d6fbf0f86f77449d97f738e { get; set; }
            public string _5d77c55886f7742fa901bcc4 { get; set; }
            public string _5dc53fd386f77469c87589a3 { get; set; }
            public string _5dc541ad86f7741416111d02 { get; set; }
            public string _5dc541c386f77469c87589a6 { get; set; }
            public string _596a20ac86f7741ddf17dbf4 { get; set; }
            public string _5ec1398886f7561e047757a5 { get; set; }
            public string _5e38261886f77429853af26c { get; set; }
            public string _5e382b6986f7741b72695045 { get; set; }
            public string _5e382d6386f77429a01f82fb { get; set; }
            public string _5e382fef86f7741e53790d40 { get; set; }
            public string _5e38356d86f7742993306cac { get; set; }
            public string _5e3835e886f77429910d4465 { get; set; }
            public string _5e58d9f286f7747c295d2892 { get; set; }
            public string _5e58daaa86f7747c25656a53 { get; set; }
            public string _5e58dabd86f7747c27218702 { get; set; }
            public string _5e58dace86f7747c295d2893 { get; set; }
            public string _5e383a6386f77465910ce1f4 { get; set; }
            public string _5e383a6386f77465910ce1f5 { get; set; }
            public string _5e383a6386f77465910ce1f6 { get; set; }
            public string _5e383a6386f77465910ce1f7 { get; set; }
            public string _5e383a6386f77465910ce1f8 { get; set; }
            public string _5e383a6386f77465910ce1f9 { get; set; }
            public string _5e58dd0a86f7747c27218709 { get; set; }
            public string _5e58dd1286f774170f538d62 { get; set; }
            public string _5e58dd1f86f7747c25656a55 { get; set; }
            public string _5e58dd2a86f7747c28220304 { get; set; }
            public string _5e4d4ac186f774264f758337 { get; set; }
            public string _5e4d4ac186f774264f758338 { get; set; }
            public string _5e4d4ac186f774264f758339 { get; set; }
            public string _5e4d4ac186f774264f75833a { get; set; }
            public string _5e4d4ac186f774264f75833b { get; set; }
            public string _5e4d4ac186f774264f75833c { get; set; }
            public string _5e58db0986f7740bef574f02 { get; set; }
            public string _5e58db2386f7747c28220302 { get; set; }
            public string _5e4d515e86f77438b2195245 { get; set; }
            public string _5e4d515e86f77438b2195246 { get; set; }
            public string _5e4d515e86f77438b2195247 { get; set; }
            public string _5e4d515e86f77438b2195248 { get; set; }
            public string _5e4d515e86f77438b2195249 { get; set; }
            public string _5e4d515e86f77438b219524a { get; set; }
            public string _5e58dbf386f7747c25656a54 { get; set; }
            public string _5e58dd9086f7747c2639ee43 { get; set; }
            public string _5e7a0773838c444eb02dd0c4 { get; set; }
            public string _5e7b30e574986d20835c2185 { get; set; }
            public string _5e74833f0b1f9954c86ee49c { get; set; }
            public string _5e748d406725d419a47e2104 { get; set; }
            public string _5e748dc9391f136a9201292e { get; set; }
            public string _5e748e12c73f9622610abb3b { get; set; }
            public string _5e7b805f0bc7e118403c847d { get; set; }
            public string _5967920f86f77468d219d632 { get; set; }
            public string _5968ec9986f7741ddd6c1012 { get; set; }
            public string _5975de1f86f7744ca53b7c82 { get; set; }
            public string _596b46d886f77457ca186189 { get; set; }
            public string _596b46ec86f77457c7006f89 { get; set; }
            public string _596b470c86f77457ca18618a { get; set; }
            public string _596b472686f77457c7006f8a { get; set; }
            public string _5979e7a386f7743ec214c7a3 { get; set; }
            public string _5e74922b35e14d4fb162de6d { get; set; }
            public string _5e749308a848081e986a58a6 { get; set; }
            public string _5e7493e9c377f60fe17d6ecb { get; set; }
            public string _5e74a5f2647a0846684a1dc4 { get; set; }
            public string _5e789b80d7dc7108e2674cce { get; set; }
            public string _5e7a14d6e77ff7644b69fec4 { get; set; }
            public string _5e74983470d454700576d1fb { get; set; }
            public string _5e7498d9c377f60fe17d6ed4 { get; set; }
            public string _5e749921dec1852497081e6d { get; set; }
            public string _5e74a6a4d9d3481b8e64369e { get; set; }
            public string _5e74a798763a4645365a6186 { get; set; }
            public string _597867e986f7741b265c6bd3 { get; set; }
            public string _5ab8d44c86f7745b2325bd0c { get; set; }
            public string _5e74a8e914847d2f305bfb94 { get; set; }
            public string _5e7b6333b4c9b140be78c134 { get; set; }
            public string _5e7a0c8ee77ff7644b69febe { get; set; }
            public string _5e7b2993f60dc341415906fb { get; set; }
            public string _5e74ac57763a4645365a618b { get; set; }
            public string _5e74ad1b5b887d725349f618 { get; set; }
            public string _5e74afbf763a4645365a6193 { get; set; }
            public string _5e74afccdfc5fc63e27a7821 { get; set; }
            public string _5e79feeb3db8ef255a7c6550 { get; set; }
            public string _5e7a13f5aabec26b11417296 { get; set; }
            public string _5e7a13facfd9c45fdf382af4 { get; set; }
            public string _5e7a13ffb9cbe86fb360bb74 { get; set; }
            public string _5e74b1c4c16d705f775de1db { get; set; }
            public string _5e7a012228b2fd48f6591c8f { get; set; }
            public string _5e79ffc73db8ef255a7c6554 { get; set; }
            public string _5e7a13c35b8bd347797f4fe5 { get; set; }
            public string _5e85e22e5549dda42377fa77 { get; set; }
            public string _5e85e32a5549ddfb4a0cdb3a { get; set; }
            public string _596b44b686f77457cb50ecca { get; set; }
            public string _596b450986f7745a7e510b54 { get; set; }
            public string _5a3fbab086f77421593d9bf0 { get; set; }
            public string _5a3fbabc86f774231d75afbe { get; set; }
            public string _5e872a5a5549ddc49d49a643 { get; set; }
            public string _5e85e5405549ddb56f1cf0d9 { get; set; }
            public string _5e85e7b45549dd422605cc1d { get; set; }
            public string _5eaaaa7c93afa0558f3b5a1f { get; set; }
            public string _5eda1a67ef0ad2643e73af31 { get; set; }
            public string _5eda1d6ec586607c09662d54 { get; set; }
            public string _5eda1da9a58a4c49c74165ee { get; set; }
            public string _5eda1dd3317f6066993c1744 { get; set; }
            public string _5f0389268580cc37797e0026 { get; set; }
            public string _5f1049d7aa82db0e8f75cb7b { get; set; }
            public string _5f1049fe6e4dc7329756c9e8 { get; set; }
            public string _5edab5a6cecc0069284c0ec2 { get; set; }
            public string _5edac4fb16d985118871ba2d { get; set; }
            public string _5edab7d3cc183c769d778bc5 { get; set; }
            public string _5edab8890880da21347b3826 { get; set; }
            public string _5edab8e216d985118871ba18 { get; set; }
            public string _5edababacecc0069284c0ec7 { get; set; }
            public string _5f03969a51823847c253afa0 { get; set; }
            public string _5f104ae158bd417a8a3e9d8f { get; set; }
            public string _5f104af087fa885f9d696bed { get; set; }
            public string _5edabacabcf60e4a143cb29f { get; set; }
            public string _5edabb0b0c502106f869bc03 { get; set; }
            public string _5edabb950c502106f869bc04 { get; set; }
            public string _5edabbff0880da21347b382b { get; set; }
            public string _5edabc2ca0055865214cb5a6 { get; set; }
            public string _5edabdea60bdcc7ff3558119 { get; set; }
            public string _5edabe120880da21347b382d { get; set; }
            public string _5edabed50880da21347b382e { get; set; }
            public string _5edabf0fcc183c769d778bcc { get; set; }
            public string _5f039da057a46716b610b577 { get; set; }
            public string _5f071a9727cec53d5d24fe3b { get; set; }
            public string _5f071ae396d1ae55e476abc4 { get; set; }
            public string _5f071b2a8ca6db7f3b41215f { get; set; }
            public string _5edac0e02ddc9e4c802cd969 { get; set; }
            public string _5edac1040880da21347b3845 { get; set; }
            public string _5edac13760bdcc7ff355811f { get; set; }
            public string _5edac1530880da21347b3846 { get; set; }
            public string _5edac190cecc0069284c0ed2 { get; set; }
            public string _5edac1b2930f5454f51dcac4 { get; set; }
            public string _5edac1e116d985118871ba24 { get; set; }
            public string _5edac1fccc183c769d778bd3 { get; set; }
            public string _5edac22860bdcc7ff3558124 { get; set; }
            public string _5edac2582ddc9e4c802cd970 { get; set; }
            public string _5edac2897869412e9c669c32 { get; set; }
            public string _5edac2a260bdcc7ff3558127 { get; set; }
            public string _5edac2cc16d985118871ba29 { get; set; }
            public string _5edac2e10bb72a50635c2bf9 { get; set; }
            public string _5c9b5e3f86f7744aab7329b5 { get; set; }
            public string _5edac37c218d181e29451453 { get; set; }
            public string _5edac3dfd143ed1d6378d13d { get; set; }
            public string _5edac3f60880da21347b384e { get; set; }
            public string _5edac465a0055865214cb5b6 { get; set; }
            public string _5f046f9825b2ad51bd275800 { get; set; }
            public string _5f04935cde3b9e0ecf03d864 { get; set; }
            public string _5f04944b69ef785df740a8c9 { get; set; }
            public string _5f0495458654d20be3564f4c { get; set; }
            public string _5f0495b8efefac7f7227de63 { get; set; }
            public string _5f07025e27cec53d5d24fe25 { get; set; }
            public string _5f0702c3d9d49120185e6323 { get; set; }
            public string _5f070323d57aeb6e09253785 { get; set; }
            public string _5f070350f6b5847ad975ceac { get; set; }
            public string _5edac657cc183c769d778bdc { get; set; }
            public string _5edac6db0bb72a50635c73b7 { get; set; }
            public string _5edac79da0055865214cb5be { get; set; }
            public string _5edac7f4cc183c769d778bdf { get; set; }
            public string _5edac8483c809a44ef12b4d2 { get; set; }
            public string _5eec9d054110547f1f545c99 { get; set; }
            public string _5eff5674befb6436ce3bbaf7 { get; set; }
            public string _5ede5528bc2ff1141a199367 { get; set; }
            public string _5ee0e5a8c321a77fc55084d2 { get; set; }
            public string _5ee8eea538ca5b3b4f3c4647 { get; set; }
            public string _5ee8eecc0b4ef7326256c660 { get; set; }
            public string _5ef094ac32e6cc3234361a30 { get; set; }
            public string _5ede56b7fe4acc3830718650 { get; set; }
            public string _5edea1ed61c2534c4f043d80 { get; set; }
            public string _5edea20f29445733cb4c29cd { get; set; }
            public string _5ee0d988c321a77fc55084cf { get; set; }
            public string _5ee0e722c321a77fc55084d5 { get; set; }
            public string _5ee8ec5ed72d953f5d2aabd1 { get; set; }
            public string _5ee8ecd75eb3205dae135d17 { get; set; }
            public string _5ee8ed18d72d953f5d2aabd4 { get; set; }
            public string _5ee8eddde932d53763761b2c { get; set; }
            public string _5ee8edf1500391756d7498a7 { get; set; }
            public string _5f0488c590eea473df674002 { get; set; }
            public string _5f04983ffbed7a08077b4367 { get; set; }
            public string _5f0da368ee0d8b5aa14a625f { get; set; }
            public string _5f970525cfe8173d12189403 { get; set; }
            public string _5f75c801ce26be0d620b7ff4 { get; set; }
            public string _5f995e4959c80875e62a667d { get; set; }
            public string _5f71d67f413b7a71bb3d4883 { get; set; }
            public string _5f8d63247b5bb8669b67ed4a { get; set; }
            public string _5f968586f4b9f84879321a41 { get; set; }
            public string _5f96875445904e5b11508ba4 { get; set; }
            public string _5979ee2986f7743ec214c7a4 { get; set; }
            public string _5979ee4586f7743ec214c7a5 { get; set; }
            public string _59819f0986f7744e6d0b7520 { get; set; }
            public string _5f9701bc261b2c7e0322947b { get; set; }
            public string _5f75c578dfacb47e146a0063 { get; set; }
            public string _5f75fb988fb5c37ce1766e99 { get; set; }
            public string _5f97010ace3c6452e951c536 { get; set; }
            public string _5f75fd4450914c5fcc42527a { get; set; }
            public string _5f8f1423d613404c430b7895 { get; set; }
            public string _5f9683f05d04e220425a7c5b { get; set; }
            public string _5f9684e4d8069972a173dd75 { get; set; }
            public string _5fd9fad9c1ce6b1a3b486d02 { get; set; }
            public string _5fd9fad9c1ce6b1a3b486d03 { get; set; }
            public string _5fd9fad9c1ce6b1a3b486d05 { get; set; }
            public string _5fd9fad9c1ce6b1a3b486d0d { get; set; }
            public string _5fdc862eaf5a054cc9333005 { get; set; }
            public string _600303250b79c6604058ce30 { get; set; }
            public string _600304b78dfec348e767018c { get; set; }
            public string _600304c38dfec348e767018e { get; set; }
            public string _6086c8ed1b0bb8063d5babb7 { get; set; }
            public string _6087d553d79a2b4e943482bf { get; set; }
            public string _60882695949eb1096c454fcd { get; set; }
            public string _608826d0a3994358a0751cfc { get; set; }
            public string _608826f3949eb1096c454fd0 { get; set; }
            public string _60882714c18cfa2a4e2afe59 { get; set; }
            public string _6088274a82e40b3c727fd164 { get; set; }
            public string _60882779d241f77b8a49785d { get; set; }
            public string _60892585b90d6f39cb74b114 { get; set; }
            public string _60892590fa70fc097863b8e5 { get; set; }
            public string _608925d455f4ac386d7e7fc4 { get; set; }
            public string _608930aa1124f748c94b801e { get; set; }
            public string _60bf751fdb5461623517069f { get; set; }
            public string _60bf75229903f107aa251f3b { get; set; }
            public string _60929ad46342771d851b827a { get; set; }
            public string _60929afc35915c62b44fd05c { get; set; }
            public string _60bf74f481c6e80e702ccc0f { get; set; }
            public string _60bf75058bb401472c1a37f7 { get; set; }
            public string _5979ef4586f77431307dc513 { get; set; }
            public string _5979ef7986f77431307dc514 { get; set; }
            public string _60916aeac49cf53e4772cc3c { get; set; }
            public string _60916b41b89a3c264d7296f9 { get; set; }
            public string _60ae0dfe2d6a8320983d19ba { get; set; }
            public string _60ae0e2c79e83a2cf96f35ce { get; set; }
            public string _60ae0f0586046842a754e21e { get; set; }
            public string _60ae0f17b809a4748759078c { get; set; }
            public string _60bf74bb2837926f405dd793 { get; set; }
            public string _60bf74c1d4526a054d42e11f { get; set; }
            public string _608bffeee0cc9c2d4d2ccb29 { get; set; }
            public string _60bf748cbf90bf6b431e8965 { get; set; }
            public string _60bf7490db5461623517069e { get; set; }
            public string _60c1d5a4fdcc6e06456a963b { get; set; }
            public string _6091698a30bb620b3239874c { get; set; }
            public string _609169cfeca522371e5725c5 { get; set; }
            public string _60ae12ffb809a474875907aa { get; set; }
            public string _60ae134cabb9675f0062cf6e { get; set; }
            public string _60bf738b4c8a3800da06e717 { get; set; }
            public string _60bf738e81c6e80e702ccc0e { get; set; }
            public string _6092942fb0f07c6ea1246e3a { get; set; }
            public string _6092947635915c62b44fd05b { get; set; }
            public string _60bf7364c53a5709996b40bf { get; set; }
            public string _60bf73682837926f405dd792 { get; set; }
            public string _608a94101a66564e74191fc3 { get; set; }
            public string _608a94ae1a66564e74191fc6 { get; set; }
            public string _60bf734bb73d016d6838ad86 { get; set; }
            public string _60bf7353bf90bf6b431e8964 { get; set; }
            public string _608ab22755f4ac386d7e7fdc { get; set; }
            public string _60bf72dda2ae0728ec716f32 { get; set; }
            public string _60bf72e04c8a3800da06e716 { get; set; }
            public string _608bd0a053b9dd01a116f474 { get; set; }
            public string _608bd0c20637f21f9934b6e4 { get; set; }
            public string _608bd136c61c4b541b381da3 { get; set; }
            public string _608bd149f597ad0a33574d74 { get; set; }
            public string _608bd2465e0ef91ab810f98a { get; set; }
            public string _608c187853b9dd01a116f480 { get; set; }
            public string _60bf72b7960b6d5d274caaf1 { get; set; }
            public string _60bf72bcc53a5709996b40be { get; set; }
            public string _608bfe32c61c4b541b381da9 { get; set; }
            public string _60a4dc7e4e734e57d07fb335 { get; set; }
            public string _60b90232ec7c6f5eb510c195 { get; set; }
            public string _60bf7284fd95cb3dfc36841f { get; set; }
            public string _60bf7293b73d016d6838ad85 { get; set; }
            public string _608a8356fa70fc097863b8f8 { get; set; }
            public string _60bf72112837926f405dd791 { get; set; }
            public string _60bf7557a2ae0728ec716f33 { get; set; }
            public string _60c0d187938d68438757cda2 { get; set; }
            public string _60cfa4cd646f74055e276545 { get; set; }
            public string _60cfa4ee1bdece56c249cbf5 { get; set; }
            public string _60cfa590f81cc57f471718cc { get; set; }
            public string _60cfa5a85f9e6175514de2e3 { get; set; }
            public string _598f0c6386f7746c837802cc { get; set; }
            public string _5b0e766b86f7746bfa618964 { get; set; }
            public string _60ec07bcd7b7cb55e94c1760 { get; set; }
            public string _60ec08fafd1bf4491c4e4550 { get; set; }
            public string _60ec09f05d67b234af3d392f { get; set; }
            public string _60ec0a9571035f300c301acb { get; set; }
            public string _60ec0ad2ad25e3185465bbd0 { get; set; }
            public string _60ec0af8a664b027ab1441af { get; set; }
            public string _60ec0b1871035f300c301acd { get; set; }
            public string _60ec2b04bc9a8b34cd453b81 { get; set; }
            public string _610144955a0e3804617cd69d { get; set; }
            public string _6101449a50bb44526c34c81d { get; set; }
            public string _60ec18b73b5f7d790a7ad034 { get; set; }
            public string _60ec1e72d7b7cb55e94c1764 { get; set; }
            public string _60ec2229fd1bf4491c4e4552 { get; set; }
            public string _6101458b43d55d251d68e4fa { get; set; }
            public string _6101458f0631930ce97dea77 { get; set; }
            public string _60e8650e5d67b234af3d3926 { get; set; }
            public string _610145de61801e6c2626a1b3 { get; set; }
            public string _610145e14a065318776a1e75 { get; set; }
            public string _60e82c12fd1bf4491c4e4547 { get; set; }
            public string _60e82c5926b88043510e0ad7 { get; set; }
            public string _6101464accda1c5f7b1dd08f { get; set; }
            public string _6101464fe5b13723fc7609ae { get; set; }
            public string _60e8658571035f300c301ac6 { get; set; }
            public string _60e865a60cef122b414a156a { get; set; }
            public string _60e866175d67b234af3d392a { get; set; }
            public string _60e866c50cef122b414a156c { get; set; }
            public string _60e866f926b88043510e0adf { get; set; }
            public string _60e867265d67b234af3d392c { get; set; }
            public string _60f028ca86abc00cdc03ab89 { get; set; }
            public string _60f028f85caf08029e0d6277 { get; set; }
            public string _610146bcccda1c5f7b1dd090 { get; set; }
            public string _610146ea70fd3f687c1a747e { get; set; }
            public string _60e745d6479eef59b01b0bdc { get; set; }
            public string _610147ac43d55d251d68e4fb { get; set; }
            public string _610147b0683d6b506f258f96 { get; set; }
            public string _60e8174d0367e10a450f7818 { get; set; }
            public string _60e81795479eef59b01b0bdf { get; set; }
            public string _610148054a065318776a1e76 { get; set; }
            public string _6101480ee5b13723fc7609af { get; set; }
            public string _60e74302d1a062318d3d225f { get; set; }
            public string _60e7432875131b4e61703b7a { get; set; }
            public string _60e7434ed1a062318d3d2260 { get; set; }
            public string _60e7436675131b4e61703b7b { get; set; }
            public string _60e7439975131b4e61703b7c { get; set; }
            public string _60e743cd0367e10a450f780e { get; set; }
            public string _60e7449875131b4e61703b7e { get; set; }
            public string _60e744c9d1a062318d3d2262 { get; set; }
            public string _61014852683d6b506f258f97 { get; set; }
            public string _6101485ce5b13723fc7609b0 { get; set; }
            public string _60e740b8b567ff641b129573 { get; set; }
            public string _610148dc4a065318776a1e77 { get; set; }
            public string _610148e775d59d19bb7329f2 { get; set; }
            public string _60e84ba726b88043510e0ad8 { get; set; }
            public string _60e85b2a26b88043510e0ada { get; set; }
            public string _6101491e6c85b961071d75fd { get; set; }
            public string _6101492343d55d251d68e4fc { get; set; }
            public string _5979fc2686f77426d702a0f2 { get; set; }
            public string _5979fc5386f77426d702a0f3 { get; set; }
            public string _5979fc7e86f77426d702a0f4 { get; set; }
            public string _5979fc9286f77426d702a0f5 { get; set; }
            public string _5a3fbbfd86f77459d52a16a8 { get; set; }
            public string _60e73ee8b567ff641b129570 { get; set; }
            public string _6101498dccda1c5f7b1dd091 { get; set; }
            public string _61014992e5b13723fc7609b1 { get; set; }
            public string _60e73333465ea8368012cc5b { get; set; }
            public string _60e733590367e10a450f7805 { get; set; }
            public string _60e73397479eef59b01b0bd5 { get; set; }
            public string _60e733b80367e10a450f7807 { get; set; }
            public string _60f028268b669d08a35bfad8 { get; set; }
            public string _60f0284e8b669d08a35bfada { get; set; }
            public string _610149ce61801e6c2626a1b4 { get; set; }
            public string _610149d34a065318776a1e78 { get; set; }
            public string _60e7249bd1a062318d3d2244 { get; set; }
            public string _60e7259e465ea8368012cc45 { get; set; }
            public string _60e725d8b567ff641b129555 { get; set; }
            public string _60e72604a6e322250215f066 { get; set; }
            public string _60e7261382576b5f4f21c495 { get; set; }
            public string _60e7261eb567ff641b129557 { get; set; }
            public string _60e72629465ea8368012cc47 { get; set; }
            public string _61014a2d6c85b961071d75fe { get; set; }
            public string _61014a3143d55d251d68e4fd { get; set; }
            public string _60e729cf5698ee7b0505743c { get; set; }
            public string _61014a600631930ce97dea78 { get; set; }
            public string _61014a6570fd3f687c1a747f { get; set; }
            public string _60effdac12fec20321367038 { get; set; }
            public string _61014aa1e10c48364e47a913 { get; set; }
            public string _610152752b0c65522065ea3b { get; set; }
            public string _613708c98cf26538cd20d59e { get; set; }
            public string _6137090327da62585838d495 { get; set; }
            public string _6179b71211973d018217d0d9 { get; set; }
            public string _6179b804bca27a099552e057 { get; set; }
            public string _61abcc6379c3a477d0122457 { get; set; }
            public string _617bd94c5a52d2390a2630c7 { get; set; }
            public string _617bf1e1d93d977d2452051f { get; set; }
            public string _617bf29a52e86c73d372a917 { get; set; }
            public string _617bf2a6f8e6c97ec70878b7 { get; set; }
            public string _597a0bb486f77426d66c0634 { get; set; }
            public string _597a0bdb86f7742717106d12 { get; set; }
            public string _597a0be986f774273b74f673 { get; set; }
            public string _597a0bf886f7742717106d13 { get; set; }
            public string _617bf3499202af497d1ccf79 { get; set; }
            public string _619040aa7d0d857927447b7b { get; set; }
            public string _617bf439ea3cfc329331243f { get; set; }
            public string _6190464d74169a76c90aa230 { get; set; }
            public string _617bf4e152e86c73d372a95d { get; set; }
            public string _617bf5860cf4a041de5b396b { get; set; }
            public string _61926522b0295324b5484459 { get; set; }
            public string _6192653d80c326298126aee1 { get; set; }
            public string _61926544bb0c712ed42d583c { get; set; }
            public string _617bf6c70cf4a041de5b3972 { get; set; }
            public string _617bf77a3de8a6689b533a2a { get; set; }
            public string _61951c30aa0f643f9a0ae1b7 { get; set; }
            public string _61951c3e2e2805073c2d29db { get; set; }
            public string _61952308aa0f643f9a0ae20f { get; set; }
            public string _6195231dd07bdc6de57b40a5 { get; set; }
            public string _61952325aa0f643f9a0ae212 { get; set; }
            public string _6195232a1e972a652931edb6 { get; set; }
            public string _6195289bea774d183b6c93aa { get; set; }
            public string _61a00eff2d708d41a34f19b4 { get; set; }
            public string _61a00f3f177fb945751bbe92 { get; set; }
            public string _6193dc1e6623e330c82e0be9 { get; set; }
            public string _6194fbf785a6d62c481a7aee { get; set; }
            public string _617fc08b30ccff6c7c37fcd3 { get; set; }
            public string _61a61c085d06a344766f3a29 { get; set; }
            public string _61904dda7845ea557e7bb808 { get; set; }
            public string _61904e76f62c89219a56e04c { get; set; }
            public string _61904ebb22e6d82ee97ccbbe { get; set; }
            public string _597a15b386f774799e5cd152 { get; set; }
            public string _597a15c386f77405ba6887d2 { get; set; }
            public string _6193dabd5f6468204470571f { get; set; }
            public string _61958d54aa0f643f9a0aed73 { get; set; }
            public string _61958d69d14ece31007e2df4 { get; set; }
            public string _61bb68ba67f83663e155e26e { get; set; }
            public string _61bb68bf87a5b8528761e4e7 { get; set; }
            public string _61bb68df1908c67d4249a20a { get; set; }
            public string _61bc887f4dbcdb6107410c97 { get; set; }
            public string _61c0c89765c79a55d81cbb9a { get; set; }
            public string _61c0c89d71e163401b193442 { get; set; }
            public string _61c0c8a00f7c43015d4f6c0a { get; set; }
            public string _61bb69e23177025bdd356695 { get; set; }
            public string _61bb6c0c6b70332c062ca7bb { get; set; }
            public string _61bb6d65d511a47f501702f0 { get; set; }
            public string _61bca61c4366cd516008c042 { get; set; }
            public string _61c0ceb8609f562952454d27 { get; set; }
            public string _61c0ced1dffe706aba5218aa { get; set; }
            public string _61c0cee0e654fb584452b96e { get; set; }
            public string _61c0ceea4515393de754f44d { get; set; }
            public string _61c19a737578f770c5341e9b { get; set; }
            public string _61bc8d823bda6405d659484a { get; set; }
            public string _61bc8d96ef0f505f0c6cd0da { get; set; }
            public string _61bc8da05d27fc7c3265d68c { get; set; }
            public string _5cb31b6188a450159d330a18 { get; set; }
            public string _59b242ea86f7741e6e0e7a86 { get; set; }
            public string _59b95de686f77418457056ef { get; set; }
            public string _5a3fbc9586f77459d52a16c4 { get; set; }
            public string _61bca728a0eae612383adf51 { get; set; }
            public string _61bca90cef0f505f0c6cd0e4 { get; set; }
            public string _61bcac49c5e5fb33866806c3 { get; set; }
            public string _61bcad27e74cdb13a01bef85 { get; set; }
            public string _61bcb55bc5e5fb33866806cd { get; set; }
            public string _61bcb5717113f767765c801f { get; set; }
            public string _61bcb586ef0f505f0c6cd0fa { get; set; }
            public string _61bcb59c54ba0f00d3551eb4 { get; set; }
            public string _61c1944a7578f770c5341e99 { get; set; }
            public string _61c194d98077ed53c5195a43 { get; set; }
            public string _61c194f657ba1629dd052a01 { get; set; }
            public string _61c19511fada4f6ce32e2cb4 { get; set; }
            public string _61c1952c2ecf5e52b12f9446 { get; set; }
            public string _61c196fb8077ed53c5195a45 { get; set; }
            public string _597a166d86f774779c70e8a4 { get; set; }
            public string _5998366886f77455853b2d9f { get; set; }
            public string _5a3fc1f286f7744ccc15d643 { get; set; }
            public string _597a178786f774799e5cd155 { get; set; }
            public string _5998360886f77456936817f3 { get; set; }
            public string _5a3fbec386f77413bd5fc20a { get; set; }
            public string _59c128b986f77415037680df { get; set; }
            public string _59c128cc86f774189b3c84b5 { get; set; }
            public string _59c128d886f77414fe7f1a64 { get; set; }
            public string _59c128f386f774189b3c84bb { get; set; }
            public string _5c92184386f7746afa2e7840 { get; set; }
            public string _60a6486cc15b714d7b0a83d4 { get; set; }
            public string _59674d5186f00443b872d5f7 { get; set; }
            public string _59624d5386f77446b872d5f7 { get; set; }
            public string _59c50f1686f77412ef2c01e7 { get; set; }
            public string _5ca5e54186f774456930b9a3 { get; set; }
            public string _5cb5e2ff86f7746ef64c979b { get; set; }
            public string _59674d5186f77446b852d5f7 { get; set; }
            public string _59c93bdb86f7742a19140434 { get; set; }
            public string _59c93c1986f7742a424eaa33 { get; set; }
            public string _59c93cbb86f7742a19140435 { get; set; }
            public string _59c93cea86f7742a08623162 { get; set; }
            public string _59c93d4e86f774496b698953 { get; set; }
            public string _59c93d8086f7742a19140436 { get; set; }
            public string _59c93d9c86f7742f6923add3 { get; set; }
            public string _59c93dbf86f7742a424eaa34 { get; set; }
            public string _596a10d886f7741ddf11dbf0 { get; set; }
            public string _59ca1b1b86f7741b067dba42 { get; set; }
            public string _59ca1b4f86f774509a270943 { get; set; }
            public string _59674fe586f7744f4e358aa2 { get; set; }
            public string _5968929e86f7740d121082d3 { get; set; }
            public string _5977784486f774285402cf52 { get; set; }
            public string _5978b48b86f7746ef62ef859 { get; set; }
            public string _59674d5986f77446b872d5f7 { get; set; }
            public string _59ca27f786f77445aa0ddc14 { get; set; }
            public string _59ca293c86f91445a80ed047 { get; set; }
            public string _59ca29ab86f77445ab431c86 { get; set; }
            public string _59ca293c86f77445a80ed147 { get; set; }
            public string _59ca29ab86f77445ab133c86 { get; set; }
            public string _59ca2bdc86f77445a80ed148 { get; set; }
            public string _59ca2c3086f77445aa0ddc15 { get; set; }
            public string _59ca2c9e86f77428ea721232 { get; set; }
            public string _59ca2cbe86f7740fe95c3e52 { get; set; }
            public string _5c922dde86f77438500a0fec { get; set; }
            public string _59ca2fba86f77445e4732b25 { get; set; }
            public string _5b05468f86f774030379eb74 { get; set; }
            public string _5b0548e686f7740306753506 { get; set; }
            public string _5cb3393888a4505d02042061 { get; set; }
            public string _5cb3397c88a450159a723d79 { get; set; }
            public string _5c9a17c686f7747dbe2da3c1 { get; set; }
            public string _5a0317da86f77451cb427295 { get; set; }
            public string _5a0325f286f7744384509230 { get; set; }
            public string _5a37d80986f774245c063b69 { get; set; }
            public string _5a03282286f77456b91542ef { get; set; }
            public string _5a03289686f7745dbc6c5063 { get; set; }
            public string _5a0328b086f77457a7099ea5 { get; set; }
            public string _5a0328cb86f77456b91543b8 { get; set; }
            public string _5a0328f586f774580168ced4 { get; set; }
            public string _5a03290586f774584d1594c4 { get; set; }
            public string _5a280b3c86f7741b16366337 { get; set; }
            public string _5a280b5486f7741f751bfeea { get; set; }
            public string _5a3ba62786f7742c9d4f5ee9 { get; set; }
            public string _5a3ba65f86f7743af1475f11 { get; set; }
            public string _5c94f65286f77455185027ee { get; set; }
            public string _5a044a6c86f7747370402d91 { get; set; }
            public string _5a280f8d86f774141b501756 { get; set; }
            public string _5a27d81a86f774472a6e0456 { get; set; }
            public string _5a27d85286f77448d82084e7 { get; set; }
            public string _5a3ba11786f7742c9d4f5d29 { get; set; }
            public string _5bcf241486f7746a4959344a { get; set; }
            public string _5be40b2a88a45079e30e92b5 { get; set; }
            public string _5c93794086f7740a13567867 { get; set; }
            public string _596762ec86f77426d3687a87 { get; set; }
            public string _5968941f86f7740d1570bbd2 { get; set; }
            public string _5968943f86f7740d137ebfc2 { get; set; }
            public string _5968948986f7740d121082d4 { get; set; }
            public string _5a3fbdb086f7745a554f0c31 { get; set; }
            public string _5a27e73f86f7740fb275c94b { get; set; }
            public string _5a27e75886f7740aef4a9157 { get; set; }
            public string _5a29653986f77406a3435b26 { get; set; }
            public string _5c9394a986f7741228714be3 { get; set; }
            public string _5a27fc8186f7746371546243 { get; set; }
            public string _5a27fc9686f774675744bb60 { get; set; }
            public string _5a37e8ae86f77415076b401d { get; set; }
            public string _5c939d0e86f774185203c4c3 { get; set; }
            public string _5a27ffb186f774192932b3d5 { get; set; }
            public string _5a27ffc786f77415ca58ae47 { get; set; }
            public string _5a294f1686f774340c7b7e4a { get; set; }
            public string _5a294f3386f77433e923f9cd { get; set; }
            public string _5a3ba34286f7744eb240406a { get; set; }
            public string _5a3ba3b086f7745ab1081101 { get; set; }
            public string _5a28017786f77452f6318b1b { get; set; }
            public string _5a2801f986f774531b679875 { get; set; }
            public string _5a28023f86f774528903dd1e { get; set; }
            public string _5a3ba47986f7744df8667505 { get; set; }
            public string _5a3ba4ba86f7744df759b1e5 { get; set; }
            public string _5c939f2186f774122b6e7854 { get; set; }
            public string _5c9a170386f77438c80164eb { get; set; }
            public string _5cb5fd3d86f7746ef64ca33c { get; set; }
            public string _5a28051286f7740eb10bac04 { get; set; }
            public string _5a3ba51d86f7743af1475c3a { get; set; }
            public string _5a2806b386f77420062f0fbd { get; set; }
            public string _5a2806e086f774291b084041 { get; set; }
            public string _5a2806f886f774513d3e69f5 { get; set; }
            public string _5fe0e9ed3f3a7d4169035e8e { get; set; }
            public string _5a28127b86f7743808504ecc { get; set; }
            public string _5a28151986f77466837984c9 { get; set; }
            public string _5a28152b86f7740ab40845fb { get; set; }
            public string _5a28157486f77405822f36c1 { get; set; }
            public string _5a28159686f77405710b1e65 { get; set; }
            public string _5a2815c186f77405822f36ce { get; set; }
            public string _5a2815d786f774725a5893a6 { get; set; }
            public string _5a28163686f7740ab4084611 { get; set; }
            public string _5a28164786f77405822f36d9 { get; set; }
            public string _5a28183186f774398675d127 { get; set; }
            public string _5a28184c86f774376e43772a { get; set; }
            public string _5a2819c886f77460ba564f38 { get; set; }
            public string _5a2e966286f7742f6c4f27a6 { get; set; }
            public string _5a3ba76486f7744d39436da2 { get; set; }
            public string _59675e1d86f77414b07f137d { get; set; }
            public string _5967938c86f77468cf5f9f54 { get; set; }
            public string _5968ed3186f77420d2328013 { get; set; }
            public string _5a3fbe3a86f77414422e0d9b { get; set; }
            public string _5a37de5486f7741535394d69 { get; set; }
            public string _5a3ba7db86f7744f0e568c9c { get; set; }
            public string _5c9de99286f7741ced54c902 { get; set; }
            public string _5a281efe86f7745bc42005cc { get; set; }
            public string _5a37dc0c86f77469da071ef2 { get; set; }
            public string _5a3ba97386f77459df27d10e { get; set; }
            public string _5a37db0c86f7745b8f4be68a { get; set; }
            public string _5a3baa2586f7745b791b72fa { get; set; }
            public string _5a28221e86f7741d5b719624 { get; set; }
            public string _5a28223786f7741c7a0b5401 { get; set; }
            public string _5a2822de86f7740a245249ce { get; set; }
            public string _5a2e958d86f77416be092111 { get; set; }
            public string _5a28235e86f7741da250b438 { get; set; }
            public string _5be0198686f774595412d9c4 { get; set; }
            public string _5ec137962d5b8510d548aef1 { get; set; }
            public string _5ec137dcc367fc6781104613 { get; set; }
            public string _5a27d34586f7744e1115b327 { get; set; }
            public string _5a56489d86f7740cfe70eba2 { get; set; }
            public string _5db9e0bf60635026b067afa6 { get; set; }
            public string _5db9e0d3b1325a429a5d7d55 { get; set; }
            public string _5db9e0e0c5624a3ce7239a88 { get; set; }
            public string _596895f986f7740d14064722 { get; set; }
            public string _5968962686f7740e7266d973 { get; set; }
            public string _596896c386f7740d1570bbd4 { get; set; }
            public string _5a6873bc86f7741f8d4589a3 { get; set; }
            public string _5a6873d786f7743ad1151d6e { get; set; }
            public string _5a6873ec86f7743cc55d8622 { get; set; }
            public string _5a6874a186f77474f43809fd { get; set; }
            public string _5a68760f86f7743cc55d8709 { get; set; }
            public string _5a68763786f77474c33a40a1 { get; set; }
            public string _5a68764c86f77474c4269f3c { get; set; }
            public string _5a68770f86f774747d4b0d8b { get; set; }
            public string _5a68776786f774759f1f55f6 { get; set; }
            public string _5a68777586f774747d4b0d9e { get; set; }
            public string _5a68778c86f77423391f38f0 { get; set; }
            public string _5a6878e886f7745e65687985 { get; set; }
            public string _5a6879be86f774284429b1bb { get; set; }
            public string _5a687a1c86f7745f2152168c { get; set; }
            public string _5accd5e386f77463027e9397 { get; set; }
            public string _5acf375f86f7741bb8377ff7 { get; set; }
            public string _5accd9b686f774112d7173d1 { get; set; }
            public string _5acf37a186f7741843346d0c { get; set; }
            public string _5acf37ad86f77418420befe6 { get; set; }
            public string _5accde3686f7740cea1b7ec2 { get; set; }
            public string _5acf37d486f7741841752ffc { get; set; }
            public string _5acf37df86f7741bb8377ffc { get; set; }
            public string _5acce08b86f7745f8521fa64 { get; set; }
            public string _5acf381a86f7741ce21f9aee { get; set; }
            public string _5acf382686f7741cdb2f7ef6 { get; set; }
            public string _5acce11786f77411ed6fa6eb { get; set; }
            public string _5acf383686f7741bb8377fff { get; set; }
            public string _5acf383d86f7741bb8378000 { get; set; }
            public string _5968975586f7740e7266d974 { get; set; }
            public string _5accdfdb86f77412265cbfc9 { get; set; }
            public string _5acf37fa86f7741844039008 { get; set; }
            public string _5acf380186f7741844039009 { get; set; }
            public string _5ac7a4ba86f77409f3423628 { get; set; }
            public string _5ac7a51a86f774738a4ffc96 { get; set; }
            public string _5ac7a5d586f774383111ee63 { get; set; }
            public string _5acf388786f7741cdb2f7ef9 { get; set; }
            public string _5acf390d86f774184403900f { get; set; }
            public string _5ac502a786f7740bde1b000c { get; set; }
            public string _5ac5055a86f7745cae22b582 { get; set; }
            public string _5ac505c386f7740be0424d19 { get; set; }
            public string _5ac505e186f7740bdf2ceabe { get; set; }
            public string _5ac5061386f77417e429ce7a { get; set; }
            public string _5ac5062586f774587c327395 { get; set; }
            public string _5acf3b0986f7741bb8378499 { get; set; }
            public string _5acf3b1286f77418420bf36b { get; set; }
            public string _5ac6240786f77417204ca2b9 { get; set; }
            public string _5ac6248586f77416781dd3a3 { get; set; }
            public string _5ac624b286f77416781dd3ac { get; set; }
            public string _5acf3b2586f7741cdb2f7f8b { get; set; }
            public string _5acf3b2a86f7741cdb2f7f8c { get; set; }
            public string _5ac5081086f7740bde1b002f { get; set; }
            public string _5ac5082586f77418804f7d4c { get; set; }
            public string _5ac5083d86f7740be2744eed { get; set; }
            public string _5ac5084d86f7740bde1b0031 { get; set; }
            public string _5acf3b3486f7741ce21f9b06 { get; set; }
            public string _5acf3b3b86f7741ce21f9b08 { get; set; }
            public string _5ac5e0fa86f77431c305d243 { get; set; }
            public string _5ac5e13586f7746074388f93 { get; set; }
            public string _5ac5e18c86f7743ebd6c9575 { get; set; }
            public string _5acf3b6186f7741cdb2f7f8e { get; set; }
            public string _5acf3b6986f77418440390b4 { get; set; }
            public string _5ac5e79986f7747398341847 { get; set; }
            public string _5ac5e88e86f7741c5804f9db { get; set; }
            public string _5ac5e98886f77479bc6ca201 { get; set; }
            public string _5ac5ea0586f774609f36280c { get; set; }
            public string _5acf3b7186f774184175301d { get; set; }
            public string _5acf3b7886f77418420bf36f { get; set; }
            public string _5cb6f81d86f7740e9d452683 { get; set; }
            public string _5cb6f88d86f7747d215f09c1 { get; set; }
            public string _5cb6f8de86f7740e9d452685 { get; set; }
            public string _5cb6f9c586f7740ace254c44 { get; set; }
            public string _5ac7a7bf86f774132252a524 { get; set; }
            public string _5ac7a83b86f774665012340b { get; set; }
            public string _5ac7a8d386f7741321499e3c { get; set; }
            public string _5ac7a93286f774664f4cbd8c { get; set; }
            public string _5ac5eb3286f7746e7a509a09 { get; set; }
            public string _5acf3b9986f77418403493b5 { get; set; }
            public string _5acf3ba186f7741ce21f9b0c { get; set; }
            public string _5ac5ee9986f7746e7a509a26 { get; set; }
            public string _5ac5eee986f77401fd341c9e { get; set; }
            public string _5ac5ef2a86f7741c5804f9f5 { get; set; }
            public string _5ac5ef5686f77416ca60f644 { get; set; }
            public string _5ac5ef9886f7746e7a509a2d { get; set; }
            public string _5ac5eff886f7740f43322559 { get; set; }
            public string _5acf3c3086f77418d851688f { get; set; }
            public string _5acf3c3d86f7741ce21f9b1a { get; set; }
            public string _5968981986f7740d1648df42 { get; set; }
            public string _5968988286f7740d14064724 { get; set; }
            public string _59a9287986f77478ad7028d8 { get; set; }
            public string _5a3fc03286f77414d64f9941 { get; set; }
            public string _5ac61a8a86f7743a8d663c77 { get; set; }
            public string _5ac61ab986f7746e352cec8c { get; set; }
            public string _5ac61adf86f774741c1bf096 { get; set; }
            public string _5ac61b1486f7743a8f30fc84 { get; set; }
            public string _5acf3bcb86f77418403493b7 { get; set; }
            public string _5acf3bd286f7741bb83784a3 { get; set; }
            public string _5acf3dd886f77418d85168f2 { get; set; }
            public string _5acf3ddd86f77418420bf391 { get; set; }
            public string _5acf3df186f7741ce21f9b2b { get; set; }
            public string _5dbadfd186f77449467d1482 { get; set; }
            public string _5ae34b8b86f7741e5b1e5d48 { get; set; }
            public string _5af4132686f774174a49af96 { get; set; }
            public string _5af4134a86f7742574673cc5 { get; set; }
            public string _5ae3550b86f7741cf44fc799 { get; set; }
            public string _5af4136586f774551341dc75 { get; set; }
            public string _5af4139286f774522e34389b { get; set; }
            public string _5ae3570b86f7746efa6b4494 { get; set; }
            public string _5af413ae86f774522e3438a5 { get; set; }
            public string _5af413b686f774522c7a6791 { get; set; }
            public string _5ae445f386f7744e87761331 { get; set; }
            public string _5af413ce86f774522e3438ae { get; set; }
            public string _5af413e486f774522e3438df { get; set; }
            public string _5ae4479686f7744f6c79b7b3 { get; set; }
            public string _5af413fa86f77407184494f3 { get; set; }
            public string _5af4140186f774522d460775 { get; set; }
            public string _5ae44c6886f7744f1a7eb2b8 { get; set; }
            public string _5af414f286f774522f59b0d7 { get; set; }
            public string _5ae44ecd86f77414a13c970e { get; set; }
            public string _5af4154186f7745c2674236d { get; set; }
            public string _5ae4508386f7741250488337 { get; set; }
            public string _5ae450db86f7741250488359 { get; set; }
            public string _5ae450ee86f7740f9307859d { get; set; }
            public string _5ae4510786f7740fa614399f { get; set; }
            public string _5ae4511d86f7740ffc31ccb5 { get; set; }
            public string _5ae4514986f7740e915d218c { get; set; }
            public string _5af4155d86f7745b5e2aba63 { get; set; }
        }

        public class Customization
        {
            public _5cc084dd14c02e000b0550a3 _5cc084dd14c02e000b0550a3 { get; set; }
            public _5cde96047d6c8b20b577f016 _5cde96047d6c8b20b577f016 { get; set; }
            public _5fc1221a95572123ae7384a2 _5fc1221a95572123ae7384a2 { get; set; }
            public _5fc1223595572123ae7384a3 _5fc1223595572123ae7384a3 { get; set; }
            public _5fc50bddb4965a7a2f48c5af _5fc50bddb4965a7a2f48c5af { get; set; }
            public _5fc614da00efd824885865c2 _5fc614da00efd824885865c2 { get; set; }
            public _5fc614f40b735e7b024c76e9 _5fc614f40b735e7b024c76e9 { get; set; }
            public _5fc615110b735e7b024c76ea _5fc615110b735e7b024c76ea { get; set; }
            public _5fc615710b735e7b024c76ed _5fc615710b735e7b024c76ed { get; set; }
            public _5fdb4139e4ed5b5ea251e4ed _5fdb4139e4ed5b5ea251e4ed { get; set; }
            public _5fdb50bb2b730a787b3f78cf _5fdb50bb2b730a787b3f78cf { get; set; }
            public _5fdb5950f5264a66150d1c6e _5fdb5950f5264a66150d1c6e { get; set; }
            public _5fdb7571e4ed5b5ea251e529 _5fdb7571e4ed5b5ea251e529 { get; set; }
        }

        public class Error
        {
            [JsonProperty("1514 - Transaction error. The cost of goods has already changed.")]
            public string _1514TransactionErrorTheCostOfGoodsHasAlreadyChanged { get; set; }

            [JsonProperty("201 - Client not authorized or not selected game profile")]
            public string _201ClientNotAuthorizedOrNotSelectedGameProfile { get; set; }

            [JsonProperty("230 - MAX LOGIN COUNT")]
            public string _230MAXLOGINCOUNT { get; set; }

            [JsonProperty("Attempted transaction with items missing from the stash")]
            public string AttemptedTransactionWithItemsMissingFromTheStash { get; set; }

            [JsonProperty("Backend error: Unknown Error")]
            public string BackendErrorUnknownError { get; set; }
            public string BackendErrorHeader { get; set; }
            public string BackendErrorMessage { get; set; }

            [JsonProperty("Bad user loyalty level")]
            public string BadUserLoyaltyLevel { get; set; }

            [JsonProperty("Not enough space in stash")]
            public string NotEnoughSpaceInStash { get; set; }

            [JsonProperty("Offer not found")]
            public string OfferNotFound { get; set; }

            [JsonProperty("The item is already sold")]
            public string TheItemIsAlreadySold { get; set; }

            [JsonProperty("The trader is out of cash")]
            public string TheTraderIsOutOfCash { get; set; }

            [JsonProperty("The trader is out of stock")]
            public string TheTraderIsOutOfStock { get; set; }

            [JsonProperty("Trader does not deal in this type of items")]
            public string TraderDoesNotDealInThisTypeOfItems { get; set; }

            [JsonProperty("Transaction error. The cost of goods has already changed.")]
            public string TransactionErrorTheCostOfGoodsHasAlreadyChanged { get; set; }

            [JsonProperty("Unknown error")]
            public string UnknownError { get; set; }

            [JsonProperty("You have already bought the maximum amount of this item in the current restock")]
            public string YouHaveAlreadyBoughtTheMaximumAmountOfThisItemInTheCurrentRestock { get; set; }
        }

        public class Handbook
        {
            public string _5b47574386f77428ca22b2ed { get; set; }
            public string _5b47574386f77428ca22b2ee { get; set; }
            public string _5b47574386f77428ca22b2ef { get; set; }
            public string _5b47574386f77428ca22b2f0 { get; set; }
            public string _5b47574386f77428ca22b2f1 { get; set; }
            public string _5b47574386f77428ca22b2f2 { get; set; }
            public string _5b47574386f77428ca22b2f3 { get; set; }
            public string _5b47574386f77428ca22b2f4 { get; set; }
            public string _5b47574386f77428ca22b2f6 { get; set; }
            public string _5b47574386f77428ca22b32f { get; set; }
            public string _5b47574386f77428ca22b330 { get; set; }
            public string _5b47574386f77428ca22b331 { get; set; }
            public string _5b47574386f77428ca22b335 { get; set; }
            public string _5b47574386f77428ca22b336 { get; set; }
            public string _5b47574386f77428ca22b337 { get; set; }
            public string _5b47574386f77428ca22b338 { get; set; }
            public string _5b47574386f77428ca22b339 { get; set; }
            public string _5b47574386f77428ca22b33a { get; set; }
            public string _5b47574386f77428ca22b33b { get; set; }
            public string _5b47574386f77428ca22b33c { get; set; }
            public string _5b47574386f77428ca22b33e { get; set; }
            public string _5b47574386f77428ca22b33f { get; set; }
            public string _5b47574386f77428ca22b340 { get; set; }
            public string _5b47574386f77428ca22b341 { get; set; }
            public string _5b47574386f77428ca22b342 { get; set; }
            public string _5b47574386f77428ca22b343 { get; set; }
            public string _5b47574386f77428ca22b344 { get; set; }
            public string _5b47574386f77428ca22b345 { get; set; }
            public string _5b47574386f77428ca22b346 { get; set; }
            public string _5b5f6f3c86f774094242ef87 { get; set; }
            public string _5b5f6f6c86f774093f2ecf0b { get; set; }
            public string _5b5f6f8786f77447ed563642 { get; set; }
            public string _5b5f6fa186f77409407a7eb7 { get; set; }
            public string _5b5f6fd286f774093f2ecf0d { get; set; }
            public string _5b5f701386f774093f2ecf0f { get; set; }
            public string _5b5f704686f77447ec5d76d7 { get; set; }
            public string _5b5f71a686f77447ed5636ab { get; set; }
            public string _5b5f71b386f774093f2ecf11 { get; set; }
            public string _5b5f71c186f77409407a7ec0 { get; set; }
            public string _5b5f71de86f774093f2ecf13 { get; set; }
            public string _5b5f724186f77447ed5636ad { get; set; }
            public string _5b5f724c86f774093f2ecf15 { get; set; }
            public string _5b5f72f786f77447ec5d7702 { get; set; }
            public string _5b5f731a86f774093e6cb4f9 { get; set; }
            public string _5b5f736886f774094242f193 { get; set; }
            public string _5b5f737886f774093e6cb4fb { get; set; }
            public string _5b5f73ab86f774094242f195 { get; set; }
            public string _5b5f73c486f77447ec5d7704 { get; set; }
            public string _5b5f73ec86f774093e6cb4fd { get; set; }
            public string _5b5f740a86f77447ec5d7706 { get; set; }
            public string _5b5f742686f774093e6cb4ff { get; set; }
            public string _5b5f744786f774094242f197 { get; set; }
            public string _5b5f746686f77447ec5d7708 { get; set; }
            public string _5b5f748386f774093e6cb501 { get; set; }
            public string _5b5f749986f774094242f199 { get; set; }
            public string _5b5f74cc86f77447ec5d770a { get; set; }
            public string _5b5f750686f774093e6cb503 { get; set; }
            public string _5b5f751486f77447ec5d770c { get; set; }
            public string _5b5f752e86f774093e6cb505 { get; set; }
            public string _5b5f754a86f774094242f19b { get; set; }
            public string _5b5f755f86f77447ec5d770e { get; set; }
            public string _5b5f757486f774093e6cb507 { get; set; }
            public string _5b5f759686f774094242f19d { get; set; }
            public string _5b5f75b986f77447ec5d7710 { get; set; }
            public string _5b5f75c686f774094242f19f { get; set; }
            public string _5b5f75e486f77447ec5d7712 { get; set; }
            public string _5b5f760586f774093e6cb509 { get; set; }
            public string _5b5f761f86f774094242f1a1 { get; set; }
            public string _5b5f764186f77447ec5d7714 { get; set; }
            public string _5b5f78b786f77447ed5636af { get; set; }
            public string _5b5f78dc86f77409407a7f8e { get; set; }
            public string _5b5f78e986f77447ed5636b1 { get; set; }
            public string _5b5f78fc86f77409407a7f90 { get; set; }
            public string _5b5f791486f774093f2ed3be { get; set; }
            public string _5b5f792486f77447ed5636b3 { get; set; }
            public string _5b5f794b86f77409407a7f92 { get; set; }
            public string _5b5f796a86f774093f2ed3c0 { get; set; }
            public string _5b5f798886f77447ed5636b5 { get; set; }
            public string _5b5f79a486f77409407a7f94 { get; set; }
            public string _5b5f79d186f774093f2ed3c2 { get; set; }
            public string _5b5f79eb86f77447ed5636b7 { get; set; }
            public string _5b5f7a0886f77409407a7f96 { get; set; }
            public string _5b5f7a2386f774093f2ed3c4 { get; set; }
            public string _5b619f1a86f77450a702a6f3 { get; set; }
            public string _5c518ec986f7743b68682ce2 { get; set; }
            public string _5c518ed586f774119a772aee { get; set; }
        }
    }
}