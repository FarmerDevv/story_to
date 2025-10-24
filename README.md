# Story Maker

Story Maker, kullanıcıların kendi hikayelerini oluşturmasına ve düzenlemesine olanak tanıyan bir masaüstü uygulamasıdır. Bu proje, yaratıcı yazarlıkla ilgilenen bireylerin hikaye oluşturma süreçlerini kolaylaştırmayı hedefler.

## Özellikler

- **Hikaye Oluşturma**: Yeni hikayeler oluşturabilir ve bunları istediğiniz gibi paylaşabilirsiniz.
- **Düzenleme**: Mevcut hikayeleri düzenleyebilir ve güncelleyebilirsiniz.
- **Kullanıcı Dostu Arayüz**: Basit bir arayüz sayesinde kolay kullanım.
- **Özel Görseller ve Diyaloglar**: Kendi karakter yüz ifadelerinizi ve sahnelerinizi ekleyebilirsiniz.

## Kurulum

### Gerekli Yazılımlar

- **.NET SDK**: Proje, .NET platformunda geliştirildiği için sisteminizde [.NET SDK](https://dotnet.microsoft.com/download) yüklü olmalıdır.
- **Git**: Projeyi GitHub'dan klonlamak için [Git](https://git-scm.com/downloads) yüklü olmalıdır.

### Adımlar

1. **Depoyu Klonlayın**:
   ```bash
   git clone https://github.com/Farmerdevv/story_to.git
   ```
2. **Proje Dizini'ne Girin**:
   ```bash
   cd story_to
   ```
3. **Gerekli Bağımlılıkları Yükleyin**:
   ```bash
   dotnet restore
   ```
4. **Uygulamayı Çalıştırın**:
   ```bash
   dotnet run
   ```

## Dosya Yapılandırması

Projenin düzgün çalışması için belirli dosya ve klasör yapılandırmalarına ihtiyaç vardır:

### **data** Klasörü

Bu klasör, hikaye ile ilgili tüm verileri barındırır.

```
data/
├── cinematics/    # Sinematik sahneler (PNG formatında)
├── face/          # Karakter yüz ifadeleri (PNG formatında)
├── app.ico        # Uygulama simgesi
└── dialogues.txt  # Hikaye diyalogları
```

### **cinematics** Klasörü

- Hikayenizin sinematik sahnelerini içeren **PNG** formatındaki dosyalar burada bulunmalıdır.
- Örnek: `intro_scene.png`, `battle_scene.png` gibi.

### **face** Klasörü

- Karakterlerin yüz ifadelerini temsil eden **PNG** formatındaki görseller burada bulunmalıdır.
- Örnek dosyalar:
  ```
  face/
  ├── face1.png
  ├── face2.png
  └── ...
  ```

### **dialogues.txt** Dosyası

Diyalogları, ilgili yüz ifadeleri ve arka plan görselleriyle birlikte tanımlamak için aşağıdaki formatta oluşturun:

```
seni öldüreceğim|face.png|simple.png
I kill you|face.png|simple.png
```

- **Format**: `diyalog metni|yüz ifadesi görseli|arka plan görseli`
- **Örnek**:
  ```
  Merhaba!|smile.png|background1.png
  Bu bir test sahnesi.|neutral.png|background2.png
  ```

## Lisans

Bu proje [MIT Lisansı](LICENSE) ile lisanslanmıştır.

## İletişim

Herhangi bir sorunuz veya geri bildiriminiz için lütfen [issue](https://github.com/pixsel9dev/story_to/issues) oluşturun veya doğrudan bizimle iletişime geçin.
