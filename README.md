# Book Store Project
![resim](https://github.com/gceylann/BookStoreProject-Backend/blob/master/WebAPI/wwwroot/Images/671822c2f63dd5f65d8fd15c9710420b.jpg)

Bu proje Çok Katmanlı Mimari temel alınarak geliştirilmiş  bir kitap satın alma sistemidir. Projede SOLID yazılım ilkeleri benimsenmiştir.
Back-End kısmı C# ile, Front-End kısmı ise Angular ile kodlanmıştır. Veritabanı için MSSQL Yerel Veritabanı kullanılmaktadır. 
Ayrıca, projenin Front-End tarafı ve diğer uygulamalarla iletişim kurmak için hizmet katmanında bir Web API kodlanmıştır.

## Back-End
### Katmanlar
#### 1-Entities Layer: 
Program boyunca kullanılacak nesnelerin sınıflarının tanımlandığı yerdir. Bu katmandaki sınıfların her biri veritabanında bir tabloya karşılık gelir, 
bunlara ek olarak farklı tablolardan gelen verilerin birleştirildiği DTO (Data Transfer Object) sınıflarını da içerir.
#### 2-Data Access Layer: 
Veritabanı bağlantılarının ve işlemlerinin yapıldığı katmandır. Veritabanı bağlantısı için gerekli yapılandırma burada yapılır. 
Ayrıca veri çıkarma, ekleme, silme, güncelleme gibi işlemler de bu katmanda kodlanmıştır.
#### 3-Business Layer: 
İş kurallarının tanımlandığı ve kontrol edildiği katmandır. Programa bir komut geldiğinde hangi işlemleri yapması ve hangi kurallar dizisinden geçmesi 
gerektiği burada tanımlanır. Uygulamayı dikine kesen ilgi alanları(Cross-Cutting Concerns) bu katmanda tetiklenir.
#### 4-Core Layer: 
Tüm katmanlarda ortak kullanılacak yapıların ve evrensel operasyonların kodlandığı kısımdır.
####6-Servis Katmanı (Web API): 
Front-End kısmı ve diğer platformların program ile haberleşip işlem yapmasını sağlayan servislerin yazıldığı kısımdır.

### Kullanılan Teknolojiler
* .Net Core 3.1
* Restful API
* Result Türleri
* Interceptor
* Autofac
   * IoC Containers
   * AOP, Aspect Oriented Programming
       -  Caching
       -  Performance
       -  Transaction
       -  Validation
* Fluent Validation
* Cache yönetimi
* JWT Authentication
* Repository Design Pattern
* Cross Cutting Concerns
   *  Caching
   *  Validation
* Extensions
* Claim
* Claim Principal
* Exception Middleware
* Service Collection
* Error Handling
  *  Error Details
  *  Validation Error Details

### Gereksinimler
#### Paketler
- Autofac	
- Autofac.Extensions.DependencyInjection	
- Autofac.Extras.DynamicProxy	
- FluentValidation	
- Microsoft.AspNetCore.Authentication.JwtBearer	
- Microsoft.AspNetCore.Http	
- Microsoft.AspNetCore.Http.Abstractions	
- Microsoft.EntityFrameworkCore.SqlServer	
- Microsoft.Extensions.Configuration	
- Microsoft.IdentityModel.Tokens	
- NETStandard.Library	
- Newtonsoft.Json	
- System.IdentityModel.Tokens.Jwt
