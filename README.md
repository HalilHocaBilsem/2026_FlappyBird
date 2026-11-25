2026-2027 Unity Başlangıç grupları ilk projesidir.

Hareketli.cs kodunu tüm hareketli objelerde kullanabilirsiniz. 
Hız değerini 1,2,3 gibi sayılarla deneyebilirsiniz.
YokOlmaX ve OlusmaX değerleri objenin hangi konumda iken yok olup tekrar başa döneceğini belirtir. Bu değer -11 ve 11 gibi negatif/pozitif olmalı.

Eğer nesnenin yukarı aşağı rastgele bir konumda oluşmasını istiyorsanız, hareketliY alanını işaretleyin. MinY ve MaxY değerleri arasında rastgele bir yükseklikte obje oluşacaktır.

Kuş için Kus.cs kodunu kullanın.
Kuşa bir collider (CircleCollider2D) ve RigidBody2D eklemeyi unutmayın. 

Sahnede zeminde ve tavanda iki adet görünmez dikdörtgen yapın ve BoxCollider2D ekleyin. Görünmez yapmak için SpriteRenderer özellğini kapatın.

Hareketli boruya iki adet BoxCollider2D ekleyin. Birini üst boruya, diğerini alt boruya hizalayın. Collider hizalama ve boyutlandırma için BoxCollider2D'nin hemen ilk özelliği olan EditCollider butonuna tıklayın. 

İçinde birden fazla resim olan dosyaları bölmek için SpriteMode > Multiple seçin. Sonra Sprite Editor butonuna tıklayın (Gelen uyarıya "Apply" tıklayın)  Sprite Editor ekranında Slice bölümünü açıp Slice butonuna tıklayın ve sonra aynı ekrandaki Apply butonuna tıklayın. Artık resmin içindeki her bir parçayı tek tek kullanabilirsiniz.

Yerdeki çimenler için 2 adet çimeni yan yana koymalısınız. 

Başarılar, İyi Eğlenceler.
<img width="690" height="385" alt="image" src="https://github.com/user-attachments/assets/ae2605e9-fc9c-4509-a85e-d90dbc0d33e0" />
