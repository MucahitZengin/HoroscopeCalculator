namespace BurcHesaplayici
{
    public partial class Form1 : Form
    {
        Image[] img =
        {
            Properties.Resources.Aquarius, //kova
            Properties.Resources.Pisces, //balik
            Properties.Resources.Aries, //koc
            Properties.Resources.Taurus, //boga
            Properties.Resources.Gemini, //ikizler
            Properties.Resources.Cancer, //yengec
            Properties.Resources.Leo, //aslan
            Properties.Resources.Virgo, //basak
            Properties.Resources.Libra, //terazi
            Properties.Resources.Scorpius, //akrep
            Properties.Resources.Sagittarius, //yay
            Properties.Resources.Capricornus //oglak
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBurcBul_Click(object sender, EventArgs e)
        {
            
            //hesaplama icin gerekli bilgileri DateTimePickerdan aliyoruz
            int gun = dtpTarih.Value.Day;
            int ay = dtpTarih.Value.Month;

            string[] burclar = { "kova", "balýk", "koc", "boga", "ikizler", "yengeç", "aslan", "basak", "terazi", "akrep", "yay", "oglak" };

            Burc burc = new Burc();

            //for (int i = 1; i <= 11; i++)
            //{
            //    if ((ay == i && gun >= 21) || (ay == i + 1 && gun <= 19)) MessageBox.Show(burclar[i - 1]);
            //}
            //if ((ay == 12 && gun >= 21) || (ay == 1 && gun <= 19)) MessageBox.Show("Oðlak");

            if ((ay == 1 && gun >= 21) || (ay == 2 && gun <= 19))
            {
                burc.BurcAdi = "Kova";
                burc.BurcAciklama = "Yeni burç tarihleri 2023 yýlýna göre Kova 25 günlük döngüsünü 16 Þubat- 12 Mart aralýðýnda alýr fakat geçerli kabul edilen 12 burca göre 22 Ocak ve 19 Þubat aralýðýný kabul ediyoruz. Hava grubuna dahil olan Kovalarýn en bilinen özelliði saðduyulu olmasý. Ýnsancýl yapýlarý ve her koþulda iradeli kalabilmeleri sayesinde ilerlemek için yeni fýrsatlar yaratabilen kiþiler genellikle bu burç tarihleri arasýnda doðmuþ olarak karþýmýza çýkar. Yardýmsever yapýlarý nedeniyle karþýlarýna çýkan zor durumda bulunan kiþilere anýnda koþmaya çalýþýrlar. Paraya deðer vermek asla onlara göre deðildir ki bu nedenle bazen cömertliðin ucunu kaçýrabilirler. En kötü özellik olarak ihmalciliði gösterebiliriz. Yapýlarý daha rahat ve deðiþken olduðu için sorumluluk duygularý diðer burçlara oranla daha azdýr demek yanlýþ olmaz. Kavga ve gürültüden mümkün olduðunca kaçan Kovalar, barýþýn önemli olduðunu bilen ve uygulamaya çalýþan kiþilerdir. Baðýmsýzlýk duygusuna kendilerini fazlasýyla kaptýrdýklarý için ister iþ hayatý ister özel hayat olsun, kapana kýsýlmýþ gibi hissetmekten hiç hoþlanmazlar. Bir Kova ile yakýn iliþkiler kurmak istiyorsanýz ilk bilmeniz gereken þey ona her saniye hesap sormamak olduðudur.";
                burc.BurcResim = img[0];
                //MessageBox.Show(burclar[0]); // Kova
            }
            else if ((ay == 2 && gun >= 20) || (ay == 3 && gun <= 20))
            {
                burc.BurcAdi = "Balýk";
                burc.BurcAciklama = "Aþýrý duygusal olmalarý ile tanýnan Balýklarýn en güzel özelliði çok iyi empati yapabiliyor olmalarýdýr. Karþýlarýndaki kiþileri hemen anlayabilen, aþýrý derecede anlayýþlý davranan hatta çoðu zaman iyi niyeti suiistimal edilen bu burca sahip kiþilerin bir diðer iyi özelliði de hislerinin çok güçlü olmasýdýr. Sezgileri ve insancýl yaklaþýmlarýyla her ortamda kendini belli edebilen Balýklarýn sanata olan ilgileri de oldukça fazla. Hayatlarý boyunca huzurdan baþka hiçbir þeye deðer vermezler ve huzurlu hissettikleri kiþi/olay karþýsýnda her þeyden vazgeçebilirler. Sevdiklerine karþý ilgi ve alakasý yüksek olan bu kiþiler hayatlarýnda naif ve sevgiden anlayan kiþilerin bulunmasýný arzular. Su grubunda yer alan Balýk burcu canlý ve daima neþeli haliyle de ilgi görür fakat bu durum anlýktýr. Beþ dakika önce aðlayan bir Balýk bir süre sonra kahkahalar atabilir. Duygularýna göre durumlar karþýsýnda þekillenen bu kiþiler için her ne kadar hayalci denilse de aslýnda gerçek hayata bakýþlarý da bir o kadar gerçekçidir. Sadece hayal kurmadan yaþamalarý imkânsýz olan bu burca sahip kiþiler çoðu zaman gözyaþlarýna hâkim olamazlar ve tozpembe hayallerinden vazgeçmek istemezler. En kötü özelliði kendini küçümsemek olan Balýklar her koþulda verici olmayý tercih ettikleri için bazen hayal kýrýklýðý yaþayabilirler. Son olarak da yeni burç tarihleri 2018 sýralamasýna göre 13 Mart- 18 Nisan aralýðýnda doðanlar Balýk kabul ediliyor.";
                burc.BurcResim = img[1];
                //MessageBox.Show(burclar[1]); // Balýk
            }
            else if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 20))
            {
                burc.BurcAdi = "Koç";
                burc.BurcAciklama = "Hayatýnda hareket, canlýlýk ve kýpýr kýpýrlýðýn eksik olmadýðý Koç’lar için macera olmayan bir hayat kesinlikle çekilmez. Bu burcun genel özelliklerine bakacak olursak; cesaretli ve atýlgan yapýlarý nedeniyle yeni giriþimlere korkusuzca daldýklarýný söyleyebiliriz. Herhangi bir konuda öncü olmak, karþýlarýndaki kiþilere yol göstermekten hoþlanmalarý da þüphesiz liderlik özelliðini taþýyor olmaktan geliyor. Her koþulda baþarý ve zafer kazanmayý kendilerine amaç edinen Koç burcu kiþilerinin en sevilmeyen özelliði maalesef sabýrsýz olmalarýna dayanýyor. Ýçi içine sýðmayan, durumlarýn içine hemen dalabilme özelliklerini sabýrsýz yapýlarý tetikliyor. Bazen bu sabýrsýz yapýlarýndan dolayý hatalara düþseler de burç tarihleri bakýmýndan yönetici gezegenleri Mars olduðu için savaþçý yapýlarý kaybetmelerine izin vermez. Tüm özellikleri düþünülerek özel hayatlarý hakkýnda yorum yapmak gerekirse; heyecanlý, tutkulu ve cinselliðin çok ön planda ilerlediði bir hayat onlar için olmazsa olmazlar arasýnda gösterilebilir.";
                burc.BurcResim = img[2];
                //MessageBox.Show(burclar[2]); // Koç
            }
            else if ((ay == 4 && gun >= 21) || (ay == 5 && gun <= 21))
            {
                burc.BurcAdi = "Boða";
                burc.BurcAciklama = "Hayata dair istediklerini çok net belirleyebilen, amaçlarýný sýralamada sýkýntý yaþamayan ve sürekliliðe önem veren Boða burcu için çoðu astrolog “Zenginlik burcu; boðadýr.” Ýfadesini kullanýyor. Bildiðiniz gibi burçlarýn tarihleri kiþilerin özelliklerini yöneterek ilerliyor. Bu sebeple Boða burcunu incelediðimiz zaman karþýmýza ilk çýkan þey; yönetici yýldýz olarak Venüs’e sahip olmasý oluyor. Venüs ise güzellik, sevgi ve sanatý temsil eder. Yani Boða burcu olan kiþilerin ilgi alanlarý ve istekleri bu doðrultuda geliþir. Arkadaþlýk ve dostluk onlar için fazlasýyla önemli iken koruyucu özellikleri sebebiyle bazen karþý tarafý fazlasýyla baský altýna alabilirler. Sýcakkanlý olmalarý sebebiyle çok kolay arkadaþlýk kurabilen Boðalarýn dostluklarý genellikle çok uzun yýllar sürer. Sevdikleri için her türlü þeyi göze alabilme özelliklerinin yanýnda kýrýlgan ve alýngan bir yapýlarý da bulunur. Hassas bir ruha sahip olduklarý için çoðu zaman gereksiz alýnganlýk yapabilirler. Ancak gelecek için herhangi bir Boða kadýný ya da erkeði ile hayatýnýzý birleþtirmek istiyorsanýz burç tarihleri ve özellikleri arasýnda evlilik için Boðalar ile çok doðru bir karar verdiðinizi bilmelisiniz.";
                burc.BurcResim = img[3];
                //MessageBox.Show(burclar[3]); // Boða
            }
            else if ((ay == 5 && gun >= 22) || (ay == 6 && gun <= 21))
            {
                burc.BurcAdi = "Ýkizler";
                burc.BurcAciklama = "Pozitif yapýsý ve keskin zekâsý ile kendinden söz ettiren bu burca sahip olan kiþilerin en belirgin özelliði yönetici gezegeni Merkür’ün ona sunduðu canlýlýk ve zekâsý oluyor. Ýkizler, ün yapmaktan büyük keyif alan burçlar arasýnda yer alýr. Gazetecilik veya çok ünlü bir yazar olmak hem yeni bir þeyler üretmek hem de kendi isimlerini herkese duyurmak hayatta amaçladýklarý þeyler arasýnda yer alýr. Zekasýný yeteneklerine göre kullanabilen pek çok Ýkizler burcunun yenmesi gereken tek þey sürekli konuþmasý olarak kabul edilebilir. Ýçerisinde bulunan enerji ve neþeyi etrafýna konuþarak yayabilen Ýkizler’in bazen çok konuþuyor olmasý çevresine rahatsýzlýk verebilir. Ýletiþimi çok iyi olan bu kiþilerin geleceðe dair yatýrýmlarý iletiþimi yüksek iþlere yapmasýnda fayda var. Ýkili özel iliþkilerinde de oldukça hareketli olan ikizlerin hayat temposuna yetiþmek pasif kiþiler için oldukça zor bir seçim olabilir.";
                burc.BurcResim = img[4];
                //MessageBox.Show(burclar[4]); // Ýkizler
            }
            else if ((ay == 6 && gun >= 22) || (ay == 7 && gun <= 22))
            {
                burc.BurcAdi = "Yengeç";
                burc.BurcAciklama = "Yengeç burcuna sahip kiþiler merhametli, iyi niyetli ve yumuþak baþlý özellikleriyle dikkat çekiyor. Oldukça sabýrlý ve koruyucu özelliði bulunan Yengeç burcundan bir tanýdýða sahip olmak gerçekten dünyanýn en güzel hediyelerinden biri sayýlabilir. Duygularý çok hýzlý deðiþen bir burç olmasýna raðmen hayatlarýnda yer edinen kiþilere karþý hep iyi yaklaþýmlar sergilerler. Tek olumsuz özellik olarak aþýrý dikkatsiz olmalarýný söyleyebiliriz. Fiziksel açýdan genellikle orta boylu ve beyaz tenli olan Yengeçler ilerleyen günlerde beslenmelerine dikkat etmek zorunda kalabilirler. Genellikle Oðlak burcu ile çok iyi anlaþamazlar. Güven ve saygý onlar için çok önemlidir ve aile hayatýnda bu iki kavramýn yer almasýna özen gösterirler.";
                burc.BurcResim = img[5];
                //MessageBox.Show(burclar[5]); // Yengeç
            }
            else if ((ay == 7 && gun >= 23) || (ay == 8 && gun <= 22))
            {
                burc.BurcAdi = "Aslan";
                burc.BurcAciklama = "Her ne kadar da yeni burç tarihleri sýralamasýnda 11 Aðustos- 16 Eylül aralýðý Aslan burcu kabul ediliyor olsa da normal sýralamasý 23 Temmuz- 22 Aðustos olarak kabul edilir. Bu sebeple biz yeni tarihler deðil, normal kabul gören tarihlere göre Aslan burcunu yorumlayacak olursak; yönetici yýldýzý güneþ olarak ateþ grubunun güçlü burçlarýndan biridir diyebiliriz. Plan kurmak, herhangi bir olayý organize etmek tam da Aslan burcuna sahip kiþilere özel bir yetenek. Yaratýcýlýklarýný aþýrý detaycý olmalarýyla birleþtiren bu kiþilerin gözünden kaçabilecek en ufak bir detay bile bulunmuyor. Oldukça cömert olan bu kiþiler hayat emeli olarak hep yüksekleri hedefler. Her ne iþ yapýyorlarsa yapsýnlar en iyisi olmak, yüksekleri arzulamak tam da onlara göre bir durum. Bu durum çoðu zaman kendilerini aþýrý beðenme olarak geri dönerek etrafýndakileri rahatsýz etse de pozitiflikleri ile her koþulda kendilerini kabul ettirmeyi baþarýrlar.";
                burc.BurcResim = img[6];
                //MessageBox.Show(burclar[6]); // Yengeç
            }
            else if ((ay == 8 && gun >= 23) || (ay == 9 && gun <= 22))
            {
                burc.BurcAdi = "Baþak";
                burc.BurcAciklama = "Toprak grubunun zekâsý ve titizliði ile dikkat çeken Baþak burcu disiplinli yapýsýyla da her ortamda kendini belli edebilir. Aþýrýya kaçarsa fazlasýyla takýntýlý olabilecek Baþaklar genellikle titizlikleriyle gurur duyar. Etrafýndaki her þeyle ilgili olan bu burcun beðenilmek ve takdir görmek hayatlarýnda en deðer verdiði þeylerden biri olarak karþýmýza çýkar. Baþarýya ve yükselmeye önem verirler ve asla ayný noktada saymak onlara göre deðildir. Her ne kadar bazen çekingenlikleri aðýr basýyor olsa da çoðu yolu baþarma inancýyla azimle aþarlar. Zekâsý ve olaylarý bakýþ açýsýyla hep ilerleme hedefleyen bu kiþileri kýsýtlamaya çalýþmak yapýlabilecek en büyük hata olur. Ýçine kapanýk bir duruþ sergilemiþ olsalar da en yakýnlarýna karþý oldukça cana yakýn bir bakýþ açýsý sergilerler. Temizlik, aþýrý çalýþkanlýk ve hep düzenli olmaktan yana olan Baþaklar asla daðýnýk insanlarla yan yana olmak istemez. Genellikle tutumlu davranýþlar sergileyen bazý Baþaklar için pinti olduðu söylenir fakat bu durum kesinlikle doðru deðildir. Sadece kime ne derece önem verecek ne derece harcamalarýný deðiþtirecek bunun kararýný kendileri verirler. Mükemmellik onlar için çok önemli olduðu için hayatlarýnýn her alanýnda ince noktalara takýlarak ilerler ve hayatlarýnda öncelik sýrasý her zaman iþ hayatý olur.";
                burc.BurcResim = img[7];
                //MessageBox.Show(burclar[7]); // Baþak
            }
            else if ((ay == 9 && gun >= 23) || (ay == 10 && gun <= 22))
            {
                burc.BurcAdi = "Terazi";
                burc.BurcAciklama = "Güzellik ve lüksten hoþlandýðý bilinen Terazilerin aslýnda en önemli özelliði dengeli olmalarý. Hayatlarýnda ve iliþkilerinde dengeye fazlasýyla önem veren bir teraziyi kýskaca almaya çalýþmak yapýlabilecek en hatalý davranýþlar arasýnda gösterilebilir. Çok seviyeli bir arkadaþlýk kurabilen Teraziler her ortamda kendini belli edebilen ve aranan kiþiler arasýnda yer alýr. Özellikle erkekleri için fazlaca çapkýn olduðunu söyleyebiliriz fakat bir kez severlerse tam anlamýyla sevdiklerini de belirtelim. Dýþ görünüþlerine önem veren ve karþý taraftan da ayný inceliði arayan bu burcun kiþileri gösteriþli þeylerden çok fazla hoþlanýr. Hava grubunda yer alan Terazilerin hayatýndan sevgi eksik olmamalý ve çoðu zamanýný sevgiye dayalý iþlerde harcamasý gerekir. Sanat ile aralarý iyi olan bu kiþilerin saygýlý ve zarif duruþlarý etraflarýndaki kiþileri etkilemede kullandýklarý bir silah. Fiziksel anlamda hem Terazi kadýnlarý hem de erkekleri oldukça çekici bir görünüme sahiptir. Temizlik ve bakýmlý olmaya özen gösteren ve ayný þeyi karþý taraftan da bekleyen Teraziler genellikle uzun boylu ve beyaz tenli olurlar.";
                burc.BurcResim = img[8];
                //MessageBox.Show(burclar[8]); // Terazi
            }
            else if ((ay == 10 && gun >= 23) || (ay == 11 && gun <= 21))
            {
                burc.BurcAdi = "Akrep";
                burc.BurcAciklama = "Akrep burcu tarihi 23 Ekim- 21 Kasým aralýðý olarak kabul ediliyor fakat yeni burç tarihleri açýsýndan sadece 6 günlük dilim Akreplere ayrýlýyor. Bu tarihlere göre 24 Kasým- 29 Kasým aralýðý yeni Akrep burcu tarihi kabul ediliyor. Su grubunun en acýmasýz ve korkulan burcu sayýlan Akrepler kararlýlýðý, inatçýlýðý ve intikam alma duygusunu yüksek oranda taþýyor olmasýyla da göz korkutan burçlar arasýnda gösterilebilir. Mars ve Plüton yönetici yýldýzýna sahip bu burcun sezgileri fazlasýyla güçlü olup, olaylarý inceleme þekli de fazlasýyla detaycý denilebilir. Tutkulu, þehvet seven ve savaþa savaþ taktiðini kullanan Akrepler için yenilgiyi kabullenmek oldukça zor bir durum. Çekici, cazibeli ve yeni þartlara kolay uyum saðlama özelliði ile ortamlarda dikkati üstüne çekebilen Akrepler birini umursamýyor ise ihmal etme, erteleme ve umursamama düzeyleri yükselebilir. Korkusuz ve acýmasýz olmalarý ise en olumsuz özellikleri arasýnda gösterilebilir. Tuttuðunu kopartabilen Akrepler eðer içlerinde yanan ateþi dizginlemeyi öðrenemezlerse kendilerine zarar vermeye baþlarlar. Koç burcundan olanlar ile aralarý çok iyi deðildir.";
                burc.BurcResim = img[9];
                //MessageBox.Show(burclar[9]); // Akrep
            }
            else if ((ay == 11 && gun >= 22) || (ay == 12 && gun <= 21))
            {
                burc.BurcAdi = "Yay";
                burc.BurcAciklama = "Çoðu durumda “Kendini beðenmiþ” olarak mimlenen Yaylar çoðu zaman karþý taraftaki kiþileri küçümser. Bu sebeple bir Yay erkek veya kadýnýn gerçekten tanýmýyorsanýz kesinlikle elektrik alamayabilirsiniz. Tanýdýkça aslýnda kendini beðenmiþlik durumunun kendilerine hissettikleri güvenden olduðunu anlayabilirsiniz. Bazý kiþilerde narsistik düzeyine ulaþan kendini beðenme durumu, bazý kiþilerde daha dengeli ve iyimser boyutta kabul edilebilir. Araþtýrmacý kiþilikleri nedeniyle yeni þeyler öðrenmek, yeni yerler gezmek ve keþifler yapmak tam olarak da ateþ grubunun güçlü burçlarýndan Yay’a göredir. Yaptýklarý iþlerde, arkadaþ ortamlarýnda ve hayatýn genel olarak her alanýnda ünlü olmayý seven bu burç kiþileri ayný zamanda oldukça giriþken bir yapýya sahiptirler. Kendilerine olan aþýrý güveniyle asla her olaya anýnda atýlan yaylarýn ellerinden bir uçan bir kaçan kurtulabilir. Öncü olmak ve olaylarý yönetmeye bayýlan Yay burcu kiþileri kendisi gibi olan insanlarla kolay kolay anlaþamaz ve genellikle Ýkizler burcundan kiþilerle arkadaþlýk kurmalarý çok zor olur. Bu nedenle çevrelerinde genellikle yönetilebilecek kiþiler bulunur. Giyim konusunda da standart tarzlardan hoþlanmayan ve kendilerine has kýyafetleri taþýmaktan hoþlandýklarýný söyleyebiliriz.";
                burc.BurcResim = img[10];
                //MessageBox.Show(burclar[10]); // Yay
            }
            else if ((ay == 12 && gun >= 22) || (ay == 1 && gun <= 19))
            {
                burc.BurcAdi = "Oðlak";
                burc.BurcAciklama = "22 Aralýk ve 21 Ocak aralýðý Oðlak burcu tarihi olarak kabul edilir ve bu tarihler arasýnda toprak grubunun kararlý yapýsýyla dikkat çeken burcu olarak karþýmýza çýkar. Direniþ doðal olarak yapýsýnda bulunan oðlak burcu tarihi yeni burç tarihlerine göre 20 Ocak- 15 Þubat aralýðýný kapsýyor ve tam olarak 27 gün döngüsünde sayýlýyor. Yükseklere ulaþmak ve zirvede kalmayý hedefleyen Oðlak burcu kiþilerinin çok fazla meraklý olmasý çoðu zaman sevilmez. Ancak kararlý yapýsý ve önlem almadan duramýyor olmasý çoðu zaman risklerden kolayca kurtulmasýný saðlayabilir. Satürn yönetici yýldýzý etkisinde ilerleyen bu burca sahip kiþilerin çok güçlü deðer yargýlarý vardýr. Sabýrlý yapýlarý ve sorumluluk duygusu yüksek kiþiler olmasý nedeniyle de olaylar ve kiþiler karþýsýnda soðukkanlý bir þekilde kalabilirler. Ýþ hayatlarýna fazla düþkün olan Oðlaklar eðer dengeyi iyi kuramazsa özel hayatlarýný ihmal edebilirler. Rahatlýða fazlasýyla önem verdikleri için hayatlarýnýn her alanýnda keyifli olmaya özen gösterirler. Genellikle koyu saç rengine sahip olan Oðlak burcu kiþilerinin özellikle de çene hatlarý oldukça keskin olur. Ýlerleyen yaþlarda da bu durumun giderek oturmaya baþlamasý özellikle erkek Oðlaklara karizmatik bir hava katabilir.";
                burc.BurcResim = img[11];
                //MessageBox.Show(burclar[11]); // Oðlak
            }

            //alinan bilgiler panele aktariliyor
            lblAd.Text = burc.BurcAdi;
            rtxAciklama.Text = burc.BurcAciklama;
            picResim.Image = burc.BurcResim;

            pnlBurc.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ilk acilista burc bilgilerini gosteren panel gorunmesin
            pnlBurc.Hide();

            //Pencereyi tutup sürükleyebilmek için
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            pnlBurc.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Pencereyi tutup sürükleyebilmek için gerekli metotlar

        private bool isDragging = false;
        private Point lastCursorPos;
        private Point lastFormPos;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursorPos = Cursor.Position;
            lastFormPos = Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int dx = Cursor.Position.X - lastCursorPos.X;
                int dy = Cursor.Position.Y - lastCursorPos.Y;
                Location = new Point(lastFormPos.X + dx, lastFormPos.Y + dy);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}