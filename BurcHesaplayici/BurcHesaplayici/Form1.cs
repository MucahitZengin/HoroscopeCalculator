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

            string[] burclar = { "kova", "bal�k", "koc", "boga", "ikizler", "yenge�", "aslan", "basak", "terazi", "akrep", "yay", "oglak" };

            Burc burc = new Burc();

            //for (int i = 1; i <= 11; i++)
            //{
            //    if ((ay == i && gun >= 21) || (ay == i + 1 && gun <= 19)) MessageBox.Show(burclar[i - 1]);
            //}
            //if ((ay == 12 && gun >= 21) || (ay == 1 && gun <= 19)) MessageBox.Show("O�lak");

            if ((ay == 1 && gun >= 21) || (ay == 2 && gun <= 19))
            {
                burc.BurcAdi = "Kova";
                burc.BurcAciklama = "Yeni bur� tarihleri 2023 y�l�na g�re Kova 25 g�nl�k d�ng�s�n� 16 �ubat- 12 Mart aral���nda al�r fakat ge�erli kabul edilen 12 burca g�re 22 Ocak ve 19 �ubat aral���n� kabul ediyoruz. Hava grubuna dahil olan Kovalar�n en bilinen �zelli�i sa�duyulu olmas�. �nsanc�l yap�lar� ve her ko�ulda iradeli kalabilmeleri sayesinde ilerlemek i�in yeni f�rsatlar yaratabilen ki�iler genellikle bu bur� tarihleri aras�nda do�mu� olarak kar��m�za ��kar. Yard�msever yap�lar� nedeniyle kar��lar�na ��kan zor durumda bulunan ki�ilere an�nda ko�maya �al���rlar. Paraya de�er vermek asla onlara g�re de�ildir ki bu nedenle bazen c�mertli�in ucunu ka��rabilirler. En k�t� �zellik olarak ihmalcili�i g�sterebiliriz. Yap�lar� daha rahat ve de�i�ken oldu�u i�in sorumluluk duygular� di�er bur�lara oranla daha azd�r demek yanl�� olmaz. Kavga ve g�r�lt�den m�mk�n oldu�unca ka�an Kovalar, bar���n �nemli oldu�unu bilen ve uygulamaya �al��an ki�ilerdir. Ba��ms�zl�k duygusuna kendilerini fazlas�yla kapt�rd�klar� i�in ister i� hayat� ister �zel hayat olsun, kapana k�s�lm�� gibi hissetmekten hi� ho�lanmazlar. Bir Kova ile yak�n ili�kiler kurmak istiyorsan�z ilk bilmeniz gereken �ey ona her saniye hesap sormamak oldu�udur.";
                burc.BurcResim = img[0];
                //MessageBox.Show(burclar[0]); // Kova
            }
            else if ((ay == 2 && gun >= 20) || (ay == 3 && gun <= 20))
            {
                burc.BurcAdi = "Bal�k";
                burc.BurcAciklama = "A��r� duygusal olmalar� ile tan�nan Bal�klar�n en g�zel �zelli�i �ok iyi empati yapabiliyor olmalar�d�r. Kar��lar�ndaki ki�ileri hemen anlayabilen, a��r� derecede anlay��l� davranan hatta �o�u zaman iyi niyeti suiistimal edilen bu burca sahip ki�ilerin bir di�er iyi �zelli�i de hislerinin �ok g��l� olmas�d�r. Sezgileri ve insanc�l yakla��mlar�yla her ortamda kendini belli edebilen Bal�klar�n sanata olan ilgileri de olduk�a fazla. Hayatlar� boyunca huzurdan ba�ka hi�bir �eye de�er vermezler ve huzurlu hissettikleri ki�i/olay kar��s�nda her �eyden vazge�ebilirler. Sevdiklerine kar�� ilgi ve alakas� y�ksek olan bu ki�iler hayatlar�nda naif ve sevgiden anlayan ki�ilerin bulunmas�n� arzular. Su grubunda yer alan Bal�k burcu canl� ve daima ne�eli haliyle de ilgi g�r�r fakat bu durum anl�kt�r. Be� dakika �nce a�layan bir Bal�k bir s�re sonra kahkahalar atabilir. Duygular�na g�re durumlar kar��s�nda �ekillenen bu ki�iler i�in her ne kadar hayalci denilse de asl�nda ger�ek hayata bak��lar� da bir o kadar ger�ek�idir. Sadece hayal kurmadan ya�amalar� imk�ns�z olan bu burca sahip ki�iler �o�u zaman g�zya�lar�na h�kim olamazlar ve tozpembe hayallerinden vazge�mek istemezler. En k�t� �zelli�i kendini k���msemek olan Bal�klar her ko�ulda verici olmay� tercih ettikleri i�in bazen hayal k�r�kl��� ya�ayabilirler. Son olarak da yeni bur� tarihleri 2018 s�ralamas�na g�re 13 Mart- 18 Nisan aral���nda do�anlar Bal�k kabul ediliyor.";
                burc.BurcResim = img[1];
                //MessageBox.Show(burclar[1]); // Bal�k
            }
            else if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 20))
            {
                burc.BurcAdi = "Ko�";
                burc.BurcAciklama = "Hayat�nda hareket, canl�l�k ve k�p�r k�p�rl���n eksik olmad��� Ko�lar i�in macera olmayan bir hayat kesinlikle �ekilmez. Bu burcun genel �zelliklerine bakacak olursak; cesaretli ve at�lgan yap�lar� nedeniyle yeni giri�imlere korkusuzca dald�klar�n� s�yleyebiliriz. Herhangi bir konuda �nc� olmak, kar��lar�ndaki ki�ilere yol g�stermekten ho�lanmalar� da ��phesiz liderlik �zelli�ini ta��yor olmaktan geliyor. Her ko�ulda ba�ar� ve zafer kazanmay� kendilerine ama� edinen Ko� burcu ki�ilerinin en sevilmeyen �zelli�i maalesef sab�rs�z olmalar�na dayan�yor. ��i i�ine s��mayan, durumlar�n i�ine hemen dalabilme �zelliklerini sab�rs�z yap�lar� tetikliyor. Bazen bu sab�rs�z yap�lar�ndan dolay� hatalara d��seler de bur� tarihleri bak�m�ndan y�netici gezegenleri Mars oldu�u i�in sava��� yap�lar� kaybetmelerine izin vermez. T�m �zellikleri d���n�lerek �zel hayatlar� hakk�nda yorum yapmak gerekirse; heyecanl�, tutkulu ve cinselli�in �ok �n planda ilerledi�i bir hayat onlar i�in olmazsa olmazlar aras�nda g�sterilebilir.";
                burc.BurcResim = img[2];
                //MessageBox.Show(burclar[2]); // Ko�
            }
            else if ((ay == 4 && gun >= 21) || (ay == 5 && gun <= 21))
            {
                burc.BurcAdi = "Bo�a";
                burc.BurcAciklama = "Hayata dair istediklerini �ok net belirleyebilen, ama�lar�n� s�ralamada s�k�nt� ya�amayan ve s�reklili�e �nem veren Bo�a burcu i�in �o�u astrolog �Zenginlik burcu; bo�ad�r.� �fadesini kullan�yor. Bildi�iniz gibi bur�lar�n tarihleri ki�ilerin �zelliklerini y�neterek ilerliyor. Bu sebeple Bo�a burcunu inceledi�imiz zaman kar��m�za ilk ��kan �ey; y�netici y�ld�z olarak Ven�s�e sahip olmas� oluyor. Ven�s ise g�zellik, sevgi ve sanat� temsil eder. Yani Bo�a burcu olan ki�ilerin ilgi alanlar� ve istekleri bu do�rultuda geli�ir. Arkada�l�k ve dostluk onlar i�in fazlas�yla �nemli iken koruyucu �zellikleri sebebiyle bazen kar�� taraf� fazlas�yla bask� alt�na alabilirler. S�cakkanl� olmalar� sebebiyle �ok kolay arkada�l�k kurabilen Bo�alar�n dostluklar� genellikle �ok uzun y�llar s�rer. Sevdikleri i�in her t�rl� �eyi g�ze alabilme �zelliklerinin yan�nda k�r�lgan ve al�ngan bir yap�lar� da bulunur. Hassas bir ruha sahip olduklar� i�in �o�u zaman gereksiz al�nganl�k yapabilirler. Ancak gelecek i�in herhangi bir Bo�a kad�n� ya da erke�i ile hayat�n�z� birle�tirmek istiyorsan�z bur� tarihleri ve �zellikleri aras�nda evlilik i�in Bo�alar ile �ok do�ru bir karar verdi�inizi bilmelisiniz.";
                burc.BurcResim = img[3];
                //MessageBox.Show(burclar[3]); // Bo�a
            }
            else if ((ay == 5 && gun >= 22) || (ay == 6 && gun <= 21))
            {
                burc.BurcAdi = "�kizler";
                burc.BurcAciklama = "Pozitif yap�s� ve keskin zek�s� ile kendinden s�z ettiren bu burca sahip olan ki�ilerin en belirgin �zelli�i y�netici gezegeni Merk�r��n ona sundu�u canl�l�k ve zek�s� oluyor. �kizler, �n yapmaktan b�y�k keyif alan bur�lar aras�nda yer al�r. Gazetecilik veya �ok �nl� bir yazar olmak hem yeni bir �eyler �retmek hem de kendi isimlerini herkese duyurmak hayatta ama�lad�klar� �eyler aras�nda yer al�r. Zekas�n� yeteneklerine g�re kullanabilen pek �ok �kizler burcunun yenmesi gereken tek �ey s�rekli konu�mas� olarak kabul edilebilir. ��erisinde bulunan enerji ve ne�eyi etraf�na konu�arak yayabilen �kizler�in bazen �ok konu�uyor olmas� �evresine rahats�zl�k verebilir. �leti�imi �ok iyi olan bu ki�ilerin gelece�e dair yat�r�mlar� ileti�imi y�ksek i�lere yapmas�nda fayda var. �kili �zel ili�kilerinde de olduk�a hareketli olan ikizlerin hayat temposuna yeti�mek pasif ki�iler i�in olduk�a zor bir se�im olabilir.";
                burc.BurcResim = img[4];
                //MessageBox.Show(burclar[4]); // �kizler
            }
            else if ((ay == 6 && gun >= 22) || (ay == 7 && gun <= 22))
            {
                burc.BurcAdi = "Yenge�";
                burc.BurcAciklama = "Yenge� burcuna sahip ki�iler merhametli, iyi niyetli ve yumu�ak ba�l� �zellikleriyle dikkat �ekiyor. Olduk�a sab�rl� ve koruyucu �zelli�i bulunan Yenge� burcundan bir tan�d��a sahip olmak ger�ekten d�nyan�n en g�zel hediyelerinden biri say�labilir. Duygular� �ok h�zl� de�i�en bir bur� olmas�na ra�men hayatlar�nda yer edinen ki�ilere kar�� hep iyi yakla��mlar sergilerler. Tek olumsuz �zellik olarak a��r� dikkatsiz olmalar�n� s�yleyebiliriz. Fiziksel a��dan genellikle orta boylu ve beyaz tenli olan Yenge�ler ilerleyen g�nlerde beslenmelerine dikkat etmek zorunda kalabilirler. Genellikle O�lak burcu ile �ok iyi anla�amazlar. G�ven ve sayg� onlar i�in �ok �nemlidir ve aile hayat�nda bu iki kavram�n yer almas�na �zen g�sterirler.";
                burc.BurcResim = img[5];
                //MessageBox.Show(burclar[5]); // Yenge�
            }
            else if ((ay == 7 && gun >= 23) || (ay == 8 && gun <= 22))
            {
                burc.BurcAdi = "Aslan";
                burc.BurcAciklama = "Her ne kadar da yeni bur� tarihleri s�ralamas�nda 11 A�ustos- 16 Eyl�l aral��� Aslan burcu kabul ediliyor olsa da normal s�ralamas� 23 Temmuz- 22 A�ustos olarak kabul edilir. Bu sebeple biz yeni tarihler de�il, normal kabul g�ren tarihlere g�re Aslan burcunu yorumlayacak olursak; y�netici y�ld�z� g�ne� olarak ate� grubunun g��l� bur�lar�ndan biridir diyebiliriz. Plan kurmak, herhangi bir olay� organize etmek tam da Aslan burcuna sahip ki�ilere �zel bir yetenek. Yarat�c�l�klar�n� a��r� detayc� olmalar�yla birle�tiren bu ki�ilerin g�z�nden ka�abilecek en ufak bir detay bile bulunmuyor. Olduk�a c�mert olan bu ki�iler hayat emeli olarak hep y�ksekleri hedefler. Her ne i� yap�yorlarsa yaps�nlar en iyisi olmak, y�ksekleri arzulamak tam da onlara g�re bir durum. Bu durum �o�u zaman kendilerini a��r� be�enme olarak geri d�nerek etraf�ndakileri rahats�z etse de pozitiflikleri ile her ko�ulda kendilerini kabul ettirmeyi ba�ar�rlar.";
                burc.BurcResim = img[6];
                //MessageBox.Show(burclar[6]); // Yenge�
            }
            else if ((ay == 8 && gun >= 23) || (ay == 9 && gun <= 22))
            {
                burc.BurcAdi = "Ba�ak";
                burc.BurcAciklama = "Toprak grubunun zek�s� ve titizli�i ile dikkat �eken Ba�ak burcu disiplinli yap�s�yla da her ortamda kendini belli edebilir. A��r�ya ka�arsa fazlas�yla tak�nt�l� olabilecek Ba�aklar genellikle titizlikleriyle gurur duyar. Etraf�ndaki her �eyle ilgili olan bu burcun be�enilmek ve takdir g�rmek hayatlar�nda en de�er verdi�i �eylerden biri olarak kar��m�za ��kar. Ba�ar�ya ve y�kselmeye �nem verirler ve asla ayn� noktada saymak onlara g�re de�ildir. Her ne kadar bazen �ekingenlikleri a��r bas�yor olsa da �o�u yolu ba�arma inanc�yla azimle a�arlar. Zek�s� ve olaylar� bak�� a��s�yla hep ilerleme hedefleyen bu ki�ileri k�s�tlamaya �al��mak yap�labilecek en b�y�k hata olur. ��ine kapan�k bir duru� sergilemi� olsalar da en yak�nlar�na kar�� olduk�a cana yak�n bir bak�� a��s� sergilerler. Temizlik, a��r� �al��kanl�k ve hep d�zenli olmaktan yana olan Ba�aklar asla da��n�k insanlarla yan yana olmak istemez. Genellikle tutumlu davran��lar sergileyen baz� Ba�aklar i�in pinti oldu�u s�ylenir fakat bu durum kesinlikle do�ru de�ildir. Sadece kime ne derece �nem verecek ne derece harcamalar�n� de�i�tirecek bunun karar�n� kendileri verirler. M�kemmellik onlar i�in �ok �nemli oldu�u i�in hayatlar�n�n her alan�nda ince noktalara tak�larak ilerler ve hayatlar�nda �ncelik s�ras� her zaman i� hayat� olur.";
                burc.BurcResim = img[7];
                //MessageBox.Show(burclar[7]); // Ba�ak
            }
            else if ((ay == 9 && gun >= 23) || (ay == 10 && gun <= 22))
            {
                burc.BurcAdi = "Terazi";
                burc.BurcAciklama = "G�zellik ve l�ksten ho�land��� bilinen Terazilerin asl�nda en �nemli �zelli�i dengeli olmalar�. Hayatlar�nda ve ili�kilerinde dengeye fazlas�yla �nem veren bir teraziyi k�skaca almaya �al��mak yap�labilecek en hatal� davran��lar aras�nda g�sterilebilir. �ok seviyeli bir arkada�l�k kurabilen Teraziler her ortamda kendini belli edebilen ve aranan ki�iler aras�nda yer al�r. �zellikle erkekleri i�in fazlaca �apk�n oldu�unu s�yleyebiliriz fakat bir kez severlerse tam anlam�yla sevdiklerini de belirtelim. D�� g�r�n��lerine �nem veren ve kar�� taraftan da ayn� inceli�i arayan bu burcun ki�ileri g�steri�li �eylerden �ok fazla ho�lan�r. Hava grubunda yer alan Terazilerin hayat�ndan sevgi eksik olmamal� ve �o�u zaman�n� sevgiye dayal� i�lerde harcamas� gerekir. Sanat ile aralar� iyi olan bu ki�ilerin sayg�l� ve zarif duru�lar� etraflar�ndaki ki�ileri etkilemede kulland�klar� bir silah. Fiziksel anlamda hem Terazi kad�nlar� hem de erkekleri olduk�a �ekici bir g�r�n�me sahiptir. Temizlik ve bak�ml� olmaya �zen g�steren ve ayn� �eyi kar�� taraftan da bekleyen Teraziler genellikle uzun boylu ve beyaz tenli olurlar.";
                burc.BurcResim = img[8];
                //MessageBox.Show(burclar[8]); // Terazi
            }
            else if ((ay == 10 && gun >= 23) || (ay == 11 && gun <= 21))
            {
                burc.BurcAdi = "Akrep";
                burc.BurcAciklama = "Akrep burcu tarihi 23 Ekim- 21 Kas�m aral��� olarak kabul ediliyor fakat yeni bur� tarihleri a��s�ndan sadece 6 g�nl�k dilim Akreplere ayr�l�yor. Bu tarihlere g�re 24 Kas�m- 29 Kas�m aral��� yeni Akrep burcu tarihi kabul ediliyor. Su grubunun en ac�mas�z ve korkulan burcu say�lan Akrepler kararl�l���, inat��l��� ve intikam alma duygusunu y�ksek oranda ta��yor olmas�yla da g�z korkutan bur�lar aras�nda g�sterilebilir. Mars ve Pl�ton y�netici y�ld�z�na sahip bu burcun sezgileri fazlas�yla g��l� olup, olaylar� inceleme �ekli de fazlas�yla detayc� denilebilir. Tutkulu, �ehvet seven ve sava�a sava� takti�ini kullanan Akrepler i�in yenilgiyi kabullenmek olduk�a zor bir durum. �ekici, cazibeli ve yeni �artlara kolay uyum sa�lama �zelli�i ile ortamlarda dikkati �st�ne �ekebilen Akrepler birini umursam�yor ise ihmal etme, erteleme ve umursamama d�zeyleri y�kselebilir. Korkusuz ve ac�mas�z olmalar� ise en olumsuz �zellikleri aras�nda g�sterilebilir. Tuttu�unu kopartabilen Akrepler e�er i�lerinde yanan ate�i dizginlemeyi ��renemezlerse kendilerine zarar vermeye ba�larlar. Ko� burcundan olanlar ile aralar� �ok iyi de�ildir.";
                burc.BurcResim = img[9];
                //MessageBox.Show(burclar[9]); // Akrep
            }
            else if ((ay == 11 && gun >= 22) || (ay == 12 && gun <= 21))
            {
                burc.BurcAdi = "Yay";
                burc.BurcAciklama = "�o�u durumda �Kendini be�enmi�� olarak mimlenen Yaylar �o�u zaman kar�� taraftaki ki�ileri k���mser. Bu sebeple bir Yay erkek veya kad�n�n ger�ekten tan�m�yorsan�z kesinlikle elektrik alamayabilirsiniz. Tan�d�k�a asl�nda kendini be�enmi�lik durumunun kendilerine hissettikleri g�venden oldu�unu anlayabilirsiniz. Baz� ki�ilerde narsistik d�zeyine ula�an kendini be�enme durumu, baz� ki�ilerde daha dengeli ve iyimser boyutta kabul edilebilir. Ara�t�rmac� ki�ilikleri nedeniyle yeni �eyler ��renmek, yeni yerler gezmek ve ke�ifler yapmak tam olarak da ate� grubunun g��l� bur�lar�ndan Yay�a g�redir. Yapt�klar� i�lerde, arkada� ortamlar�nda ve hayat�n genel olarak her alan�nda �nl� olmay� seven bu bur� ki�ileri ayn� zamanda olduk�a giri�ken bir yap�ya sahiptirler. Kendilerine olan a��r� g�veniyle asla her olaya an�nda at�lan yaylar�n ellerinden bir u�an bir ka�an kurtulabilir. �nc� olmak ve olaylar� y�netmeye bay�lan Yay burcu ki�ileri kendisi gibi olan insanlarla kolay kolay anla�amaz ve genellikle �kizler burcundan ki�ilerle arkada�l�k kurmalar� �ok zor olur. Bu nedenle �evrelerinde genellikle y�netilebilecek ki�iler bulunur. Giyim konusunda da standart tarzlardan ho�lanmayan ve kendilerine has k�yafetleri ta��maktan ho�land�klar�n� s�yleyebiliriz.";
                burc.BurcResim = img[10];
                //MessageBox.Show(burclar[10]); // Yay
            }
            else if ((ay == 12 && gun >= 22) || (ay == 1 && gun <= 19))
            {
                burc.BurcAdi = "O�lak";
                burc.BurcAciklama = "22 Aral�k ve 21 Ocak aral��� O�lak burcu tarihi olarak kabul edilir ve bu tarihler aras�nda toprak grubunun kararl� yap�s�yla dikkat �eken burcu olarak kar��m�za ��kar. Direni� do�al olarak yap�s�nda bulunan o�lak burcu tarihi yeni bur� tarihlerine g�re 20 Ocak- 15 �ubat aral���n� kaps�yor ve tam olarak 27 g�n d�ng�s�nde say�l�yor. Y�kseklere ula�mak ve zirvede kalmay� hedefleyen O�lak burcu ki�ilerinin �ok fazla merakl� olmas� �o�u zaman sevilmez. Ancak kararl� yap�s� ve �nlem almadan duram�yor olmas� �o�u zaman risklerden kolayca kurtulmas�n� sa�layabilir. Sat�rn y�netici y�ld�z� etkisinde ilerleyen bu burca sahip ki�ilerin �ok g��l� de�er yarg�lar� vard�r. Sab�rl� yap�lar� ve sorumluluk duygusu y�ksek ki�iler olmas� nedeniyle de olaylar ve ki�iler kar��s�nda so�ukkanl� bir �ekilde kalabilirler. �� hayatlar�na fazla d��k�n olan O�laklar e�er dengeyi iyi kuramazsa �zel hayatlar�n� ihmal edebilirler. Rahatl��a fazlas�yla �nem verdikleri i�in hayatlar�n�n her alan�nda keyifli olmaya �zen g�sterirler. Genellikle koyu sa� rengine sahip olan O�lak burcu ki�ilerinin �zellikle de �ene hatlar� olduk�a keskin olur. �lerleyen ya�larda da bu durumun giderek oturmaya ba�lamas� �zellikle erkek O�laklara karizmatik bir hava katabilir.";
                burc.BurcResim = img[11];
                //MessageBox.Show(burclar[11]); // O�lak
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

            //Pencereyi tutup s�r�kleyebilmek i�in
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

        //Pencereyi tutup s�r�kleyebilmek i�in gerekli metotlar

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