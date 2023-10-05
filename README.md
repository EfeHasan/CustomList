# Özelleştirilebilir C# Generic Liste Sınıfı

Bu C# projesi, özelleştirilebilir bir generic liste sınıfını içerir. Bu Liste sınıfı, dinamik olarak büyüyen ve elemanlar eklemek, silmek ve kontrol etmek için kullanılabilen bir koleksiyonu temsil eder.

## Özellikler
- Eleman ekleme (Add)
- Belirli bir indeksteki elemanı silme (RemoveAt)
- Belirli bir elemanı silme (Remove)
- Belirli bir elemanın listede olup olmadığını kontrol etme (Contains)
- Listeyi temizleme (Clear)
- Liste elemanlarını diziye dönüştürme (ToArray)
- Liste elemanlarını List'e dönüştürme (ToList)

## Kullanım
```csharp
// Liste oluşturma
Liste<int> sayilar = new Liste<int>();

// Eleman ekleme
sayilar.Add(42);
sayilar.Add(17);

// Elemanları liste olarak okuma
sayilar.ListReader();

// Belirli bir elemanı silme
sayilar.Remove(17);

// Diziye dönüştürme
int[] dizi = sayilar.ToArray();

// Liste elemanlarını List'e dönüştürme
List<int> liste = sayilar.ToList();