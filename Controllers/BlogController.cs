using Microsoft.AspNetCore.Mvc;
using SelKirimDokumSite.Models;

namespace SelKirimDokumSite.Controllers
{
    public class BlogController : Controller
    {
        private static readonly List<BlogPost> Posts = new()
        {
            new BlogPost
            {
                Title = "Yıkım İzinleri ve Mevzuat: Nereden Başlamalı?",
                Slug = "yikim-izinleri-ve-mevzuat",
                Excerpt = "Belediye yıkım ruhsatı, trafik tedbirleri ve İSG planı: Temel kontrol listesi.",
                Content = "<p><strong>Yıkım izinleri</strong> ve mevzuat açısından doğru başlangıç, projenin hem güvenli hem de sorunsuz ilerlemesi için kritiktir. Önce mevcut yapının kayıtları incelenir; imar durumu, tapu bilgileri ve projeler temin edilir. Belediyeye başvuru dosyasında genellikle <strong>yıkım ruhsatı dilekçesi</strong>, yapı <strong>statik durumu/ekspertiz raporu</strong>, <strong>yıkım yöntem beyanı</strong> (makinalı, manuel, aşamalı), <strong>İSG planı</strong> ve <strong>atık yönetim planı</strong> yer alır. Çalışma alanı kamuya temas ediyorsa <strong>trafik ve çevre tedbirleri</strong> (yol kapama, şerit daraltma, bariyerleme, uyarı levhaları) için ilgili birimlerden onay alınır. Sağlık ve çevre boyutu açısından <strong>asbest ve tehlikeli madde araştırması</strong> yapılmadan sahaya girilmez; risk tespiti varsa <strongizolasyon</strong>, <strong>negatif basınç</strong> ve <strong>lisanslı bertaraf</strong> adımları ayrı prosedürle yürütülür. Proje ölçeğine göre <strong>ÇED muafiyeti/kararı</strong> veya çevresel bildirimler gündeme gelebilir. İşveren–yüklenici ilişkisi sözleşmede netleşir; <strong>mesleki sorumluluk</strong> ve <strong>üçüncü şahıs mali sorumluluk sigortaları</strong> güncel tutulur. Komşu parseller ve site yönetimleri <strong>yazılı bilgilendirme</strong> ile süreçten haberdar edilir; çalışma saatleri yerel düzenlemelere uyarlanır. Uygulamada <strong>toz bastırma</strong> (sürekli sulama), <strong>gürültü/titreşim yönetimi</strong> ve <strong>kontrollü moloz akışı</strong> esas alınır; enerji kaynakları için <strong>kilitleme–etiketleme (LOTO)</strong> ve elektrik/tesisat kesmeleri kayıt altına alınır. Çıkan malzemeler <strong>atık kodlarına göre ayrıştırılır</strong>; geri kazanım önceliklendirilir, kalanlar <strong>lisanslı döküm sahalarına</strong> sevk edilir ve <strong>irsaliye–teslim makbuzları</strong> dosyalanır. Yıkımın her aşaması foto/video ile belgelenir; <strong>günlük ilerleme raporları</strong>, <strong>tonaj özetleri</strong> ve <strong>risk değerlendirme güncellemeleri</strong> paylaşılır. Teslimde saha <strong>temiz ve güvenli</strong> bırakılır; belediye veya ilgili idare ile <strong>nihai kontrol</strong> yapılarak <strong>teslim tutanağı</strong> imzalanır. Böylece proje, başlangıç onaylarından nihai kapatmaya kadar **tam mevzuat uyumlu** ve izlenebilir şekilde tamamlanmış olur.</p>",
                CoverImage = "/images/gallery/Yıkımizinleri.png",
                Date = System.DateTime.Now.ToString("yyyy-MM-dd"),
                Category = "Mevzuat"
            },
            new BlogPost
            {
                Title = "Moloz Atımı ve Atık Yönetimi: Uyumlu ve Ekonomik Çözümler",
                Slug = "moloz-atimi-atik-yonetimi",
                Excerpt = "Atık kodları, lisanslı döküm sahaları ve taşıma irsaliyesi ile tam uyum.",
                Content = "<p>İnşaat, yıkım ve tadilat süreçlerinde ortaya çıkan moloz, atık yönetiminin en önemli kalemlerinden biridir. Doğru yöntemlerle yapılmayan moloz atımı hem çevresel risklere yol açar hem de maliyetleri artırır. Günümüzde moloz atımı ve atık yönetimi, yalnızca yasal düzenlemelere uygun olmakla kalmayıp aynı zamanda ekonomik çözümler sunmak açısından da stratejik bir konudur. Firmalar, atıkların doğru sınıflandırılması ve uygun araçlarla taşınması sayesinde hem zamandan hem de bütçeden tasarruf sağlayabilmektedir. Bu süreçte en kritik noktalardan biri, inşaat ve yıkım atıklarının geri dönüşüm merkezlerine yönlendirilmesidir. Özellikle beton, demir, plastik ve ahşap gibi malzemeler ayrıştırıldığında yeniden ekonomiye kazandırılabilir. Böylece hem çevresel sürdürülebilirlik desteklenir hem de maliyetler minimuma indirilir.\n\nMoloz atımında dikkat edilmesi gereken bir diğer unsur, yerel belediye ve çevre mevzuatlarına uyumdur. Gelişigüzel dökülen molozlar, hem doğaya zarar verir hem de ciddi idari yaptırımlar doğurur. Profesyonel moloz atımı hizmeti sunan firmalar, uygun araç filoları ve deneyimli ekipleriyle süreci planlı bir şekilde yönetir. Bu planlama, şantiyeden çıkan molozun güvenli şekilde toplanmasını, kamyon veya konteynerlerle taşınmasını ve en kısa sürede belirlenen döküm alanlarına teslim edilmesini kapsar. Ayrıca modern atık yönetimi çözümleri, iş güvenliği standartlarına uygun olarak çalışılmasını da sağlar. Özellikle yüksek hacimli projelerde konteyner sistemleri, hem alan kullanımını optimize eder hem de iş akışını hızlandırır.\n\nEkonomik açıdan bakıldığında, uyumlu moloz atımı ve atık yönetimi çözümleri, uzun vadede işletmelere büyük avantaj sağlar. Gereksiz nakliye masrafları, ceza riskleri ve çevreye verilen zararlar minimize edilerek daha sürdürülebilir bir yapı oluşturulur. Örneğin, beton parçalarının kırılarak dolgu malzemesi şeklinde tekrar kullanılması hem maliyet düşürür hem de çevresel fayda sağlar. Atık yönetiminde geri dönüşüm odaklı planlama yapmak, sadece bugünün değil geleceğin de kazançlı bir yaklaşımıdır. Bu nedenle inşaat sektöründe faaliyet gösteren her firmanın, moloz atımı ve atık yönetimini profesyonel destekle yürütmesi büyük önem taşır.</p>",
                CoverImage = "/images/gallery/molozatımı.png",
                Date = System.DateTime.Now.ToString("yyyy-MM-dd"),
                Category = "Atık Yönetimi"
            },
            new BlogPost
            {
                Title = "Beton Kesme/Delme: Hangi Yöntem Ne Zaman?",
                Slug = "beton-kesme-delme-yontemleri",
                Excerpt = "Elmas tel, karot, duvar testeresi: Avantaj, dezavantaj ve gürültü seviyeleri.",
                Content = "<p>Beton kesme ve delme işlemleri, inşaat sektöründe en sık ihtiyaç duyulan teknik uygulamalardan biridir. Bu yöntemler, projelerin planlama ve uygulama aşamalarında hem zaman hem de maliyet açısından kritik rol oynar. Ancak her beton yapıya aynı yöntemle müdahale etmek doğru değildir. Burada temel soru şudur: Hangi yöntemin ne zaman kullanılması gerekir? İşte bu noktada, betonun yapısı, kalınlığı, içindeki donatı miktarı ve işlem yapılacak alanın özellikleri göz önünde bulundurulmalıdır. Örneğin, kalın ve yüksek dayanımlı betonlarda elmas uçlu kesme makineleri tercih edilirken, hassas yüzeylerde titreşim kontrolü sağlayan tel kesme yöntemleri daha uygundur.\n\nBeton delme işlemlerinde en yaygın kullanılan yöntemlerden biri karot delme tekniğidir. Karot makineleri sayesinde, beton yüzeylerde dairesel ve hassas delikler açmak mümkündür. Bu yöntem, genellikle tesisat geçişleri, havalandırma boşlukları ve kablo kanalları açmak için tercih edilir. Ayrıca karot delme, düşük titreşimli yapısıyla çevredeki yapı elemanlarına zarar vermez. Öte yandan, geniş alanlarda kesme ihtiyacı olduğunda hidrolik kesme makineleri veya zincirli testere sistemleri devreye girer. Bu yöntemler, yüksek hızda ve derin kesim gerektiren projelerde zaman kazandırır. Özellikle endüstriyel projelerde doğru yöntem seçimi, iş güvenliği açısından da kritik öneme sahiptir.\n\nBeton kesme ve delme yöntemlerinin seçiminde maliyet analizi de göz ardı edilmemelidir. Yanlış yöntem seçimi hem işin uzamasına hem de ek masraflara neden olur. Örneğin, manuel kesme yöntemleri küçük çaplı işler için uygunken, büyük ölçekli projelerde verimsiz kalabilir. Bu yüzden firmalar, proje başlamadan önce detaylı bir keşif ve planlama yaparak hangi tekniğin uygulanacağını belirlemelidir. Ayrıca profesyonel ekipman kullanımı, hem iş kazalarının önüne geçer hem de ortaya çıkan işin kalitesini artırır. Beton kesme ve delme işlemlerinde kullanılan modern makineler, toz bastırma sistemleriyle birlikte çalışarak hem çevreye hem de çalışan sağlığına zarar vermeden işin tamamlanmasını sağlar.\n\nSonuç olarak, beton kesme ve delme yöntemleri projenin ölçeğine, teknik ihtiyaçlarına ve güvenlik standartlarına göre seçilmelidir. Doğru zamanda doğru yöntemi uygulamak, hem işin kalitesini yükseltir hem de maliyetleri azaltır. İnşaat sektöründe faaliyet gösteren firmalar için bu stratejik seçim, projelerin başarısında belirleyici bir rol oynar. Profesyonel destekle gerçekleştirilen beton kesme ve delme uygulamaları, hem güvenli hem de ekonomik bir çözüm sunarak sektördeki rekabet gücünü artırır.</p>",
                CoverImage = "/images/gallery/betonkesmedelmeyontem.png",
                Date = System.DateTime.Now.ToString("yyyy-MM-dd"),
                Category = "Teknik"
            }
        };

        public IActionResult Index() => View(Posts.OrderByDescending(p => p.Date).ToList());

        [Route("Blog/Post/{slug}")]
        public IActionResult Post(string slug)
        {
            var post = Posts.FirstOrDefault(p => p.Slug == slug);
            if (post == null) return NotFound();
            return View(post);
        }
    }
}