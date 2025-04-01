# Story Maker

Story Maker, kullanıcıların kendi hikayelerini oluşturmasına ve düzenlemesine olanak tanıyan bir masaüstü uygulamasıdır. Bu proje, yaratıcı yazarlıkla ilgilenen bireylerin hikaye oluşturma süreçlerini kolaylaştırmayı hedefler.


## Özellikler

- **Hikaye Oluşturma**: Yeni hikayeler oluşturabilir ve bunları istediğiniz gibi paylaşın.
- **Düzenleme**: Mevcut hikayeleri düzenleyebilir ve güncelleyebilirsiniz.
- **Kullanıcı Dostu Arayüz**: Basit bir arayüz sayesinde kolay kullanım.

## Kurulum

### Gerekli Yazılımlar

- **.NET SDK**: Proje, .NET platformunda geliştirildiği için sisteminizde [.NET SDK](https://dotnet.microsoft.com/download) yüklü olmalıdır.

### Adımlar

1. **Depoyu Klonlayın**:
   ```bash
   git clone https://github.com/pixsel9dev/story_to.git
Proje Dizinine Girin:
cd story_to
Gerekli Bağımlılıkları Yükleyin: Projede kullanılan NuGet paketlerini yüklemek için aşağıdaki komutu çalıştırın:
dotnet restore
Kullanım
Uygulamayı Çalıştırma
dotnet run


Dosya Yapılandırması
Projenin düzgün çalışması için belirli dosya ve klasör yapılandırmalarına ihtiyaç vardır:

data Klasörü:

cinematics: Bu klasöre, hikayenizin sinematik sahnelerini içeren dosyaları ekleyin png formatında olması lazımdır.

app.ico: Uygulamanızın simgesi olarak kullanılacak app.ico dosyasını bu klasöre yerleştirin.

data/
├── cinematics/
├── face/
├── app.ico
└── dialogues.txt


Bu face klasörüne, karakterlerin yüz ifadelerini temsil eden .png formatındaki görselleri ekleyin.
face/
├── character1.png
├── character2.png
└── ...
mesela ben face.png olarak bıraktım örnek olsun diye

Diyalogları, ilgili yüz ifadeleri ve arka plan görselleriyle birlikte tanımlamak için dialogues.txt dosyasını aşağıdaki formatta oluşturun:

seni öldüreceğim|face.png|simple.png
I kill you|face.png|simple.png
Burada her satır, diyalog metni|yüz ifadesi görseli|arka plan görseli şeklinde yapılandırılmalıdır.
