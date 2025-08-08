# Lists 1 - Pratik 

Bu uygulama, **C#** dilinde `List<T>` koleksiyonu kullanarak bir davetli listesi oluşturur ve listedeki isimleri **for** veya **foreach** döngüsü ile ekrana yazdırır.

---

## 🎯 Amaç

* `List<string>` kullanarak string elemanlardan oluşan bir liste oluşturmak.
* Liste elemanlarını sırasıyla ekrana yazdırmak.
* Döngü yapılarının (`for` ve `foreach`) kullanımını pekiştirmek.

---

## 🧠 Mantık Özeti

1. Davetlilerin isimleri `List<string>` yapısında tutulur.
2. `foreach` döngüsü ile liste üzerinde gezinilir.
3. Her davetli, sıra numarası ile birlikte ekrana yazdırılır.
4. Alternatif olarak **for** döngüsü ile de aynı işlem yapılabilir.

---

## 📁 Örnek Kod

```csharp
List<string> davetliler = new List<string>
{
    "Bülent Ersoy",
    "Ajda Pekkan",
    "Ebru Gündeş",
    "Hadise",
    "Hande Yener",
    "Tarkan",
    "Funda Arar",
    "Demet Akalın"
};

Console.WriteLine("** Davetliler **");
int sira = 1;
foreach (var kisi in davetliler)
{
    Console.WriteLine($"{sira} - {kisi}");
    sira++;
}
```

---

## 🖨️ Örnek Çıktı

```
** Davetliler **
1 - Bülent Ersoy
2 - Ajda Pekkan
3 - Ebru Gündeş
4 - Hadise
5 - Hande Yener
6 - Tarkan
7 - Funda Arar
8 - Demet Akalın
```

---

## 📌 Notlar

* `foreach` döngüsü, koleksiyonlar üzerinde gezinmek için daha okunaklıdır.
* Eğer liste elemanına sıra numarasıyla erişmek istersen, **for** döngüsü kullanabilirsin.

---

## 🔧 Genişletme Fikirleri

* Kullanıcıdan konsol üzerinden davetli isimlerini almak.
* Listeyi alfabetik olarak sıralamak.
* Belirli bir ismi listeden silme veya değiştirme işlemleri eklemek.
