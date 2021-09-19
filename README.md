# Modi Algoritmasi Ile Optimumluk Kontrolu

MODİ Yöntemi

Modi yönteminde boş gözelerin gizli maliyetler çevrim yapılmadan hesaplanabilir. Çevrim çözüm en
iyi değilse bir tek baş göze için yapılır. Bu nedenle modi yönteminde göze değiştirme yöntemine göre
daha hızlı sonuç alınabilir.

Yöntem doğrusal programlamadaki dual problemin çözümünden hareket eder. Bunun için öncelikle
ulaştırma modelinin dual modelini yazalım.

Primal modelde (m+n) tane kısıtlayıcı fonksiyon olduğundan, dual modelde (m+n) tane değişken
olacaktır. Primal modeldeki arz kısıtlarına karşılık gelen dual değişkenler U1 (i=1,….n) , talep kısıtlarına
karşılık gelen değişkenler Vj (j=1,…n) ile gösterilirlerse dual model amaç fonksiyonu şöyle olur:

𝑍𝑚𝑎𝑥 = ∑ ai Ui +∑ bj Vj

n

𝑗=1

𝑚

𝑖=1

Primal modeldeki (mxn) değişkene karşılık dual modelde (mxn) tane kısıtlayıcı fonksiyon vardır. Bu
fonksiyonlar şöyledir;

Ui + Vj ≤ Cij (i=1, … , m ; j=1 … ,n)

Modi yönteminin uygulanması için Ui ve Vj değerlerinin bulunması gerekir. Bu değerlerin hesabında
dolu gözeler kullanılır. Ui + Vj = dolu gözedeki Cij olması gerekir. Elde edilen denklem sayısı (m+n-1)
tane olacaktır. m+n tane bilinmeyen olduğundan Ui veya Vj ‘lerden birine keyfi olarak bir değer
verilerek (genellikle sıfır verilir) kalan Ui ve Vj değerleri hesaplanır.

Ui veya Vj değerlerinden dolu gözelerin çok olduğu satır ve sütunda olanına sıfır değeri verilirse
hesaplamalarımız daha kolay ilerler.

Ui veya Vj değerleri bulunduktan sonra bu gözelerin gizli maliyetleri şu formül yardımıyla hesaplanır:

dij = Cij-(Ui + Vj )

Bütün dij değerleri sıfır veya negatifse incelediğimiz çözümün en iyi olduğuna karar verilir.
Boş gözelerden biri veya birkaçının gizli maliyet negatifse çözüm en iyi değildir. Boş gözelerden
mutlak değeri büyük olana (gizli maliyetinin mutlak değeri) dağıtım yapılması gerekir. Göze
değiştirme yöntemindeki gibi bir evrim oluşturularak yeni dağıtım planı bulunur.
Elde edilen bu yeni çözüm içinde Ui ve Vj değerleri hesaplanarak sırasıyla işlemler yapılır. Bu en iyi
çözümü elde edinceye kadar devam eder.

Yaptığım projede kullanıcı matris değerlerini yazar. Program Modi algoritması ile optimumluk kontrolünü yapıp sonucunu göstermektedir.
 
  
Program açılış ekranı:
 
  
  

![Screenshot_4](https://user-images.githubusercontent.com/36795459/133936991-66fde9c9-e6ee-4a04-83a1-9426988865d1.png)
 
  
  

![Screenshot_5](https://user-images.githubusercontent.com/36795459/133936983-2ea85dbb-b91c-4bd4-8188-d3aa589110ee.png)
 
  
   
![Screenshot_6](https://user-images.githubusercontent.com/36795459/133936984-784fee26-6333-4e0f-8813-050e7eaeb7bd.png)
 
Örnek matris ve sonuç :
 
  
  
![Screenshot_7](https://user-images.githubusercontent.com/36795459/133936985-bef6a106-6475-414b-b8d6-7f58b17db389.png)

