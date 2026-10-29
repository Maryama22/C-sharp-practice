# Assigment Files - Sharaxaad Code-ka


---

## 1. Waxa uu qabto

| Button | Magaca (Name) | Shaqadiisa |
|---|---|---|
| Reading Other Function | `btnReader` | Akhriyaa `modules.txt`, line walba ku soo bandhigaa `OutputList` |
| Deleting the File | `btnDelete` | Backup ka samaysaa, kadib tirtiraa `modules.txt` |
| Delete The Items File | `btnDeleteItems` | Tirtiraa item la doortay, kadibna file-ka dib u qoraa |
| Sanduuqa midig (ListBox) | `OutputList` | Muujiyaa waxa file-ka ku jira |

---


---

## 3. Halka file-ku ku abuurmo

`modules.txt` waxaa lagu abuuraa folder-ka barnaamijka:

```
...\Assigment Files\bin\Debug\net8.0-windows\modules.txt
```

Sababtu waa inaan magaca file-ka ku qornay **bilaa path** (`"modules.txt"`), sidaa darteed Windows wuxuu u isticmaalaa folder-ka uu barnaamijku ka socdo.

---

## 4. Habka uu u shaqeeyo (Flow)

```
Program furmo
     |
     v
Form1_Load_1  -->  abuur modules.txt (6 line)
     |
     v
Reader  -->  akhri file-ka  -->  ListBox
     |
     v
Delete Items  -->  dooro item  -->  ka tir ListBox  -->  dib u qor file-ka
     |
     v
Delete  -->  backup (modules_backup.txt)  -->  tirtir modules.txt
```

---

## 5. Sharaxaadda method walba

### 5.1 `Form1_Load_1` - Abuurista file-ka

Wuxuu shaqeeyaa **mar kasta oo form-ku furmo**.

```csharp
StreamWriter fileWriter;
fileWriter = File.CreateText("modules.txt");
fileWriter.WriteLine("Web Development");
fileWriter.Close();
```

Saddexda tallaabo ee file-ka:

1. **Open:** `File.CreateText("modules.txt")` abuuraa file cusub (haddii hore u jiray, **wuu tirtiraa** waxa ku jiray).
2. **Process:** `WriteLine()` ayaa qoraa line walba.
3. **Close:** `Close()` ayaa xidha file-ka, si kale loo isticmaali karo.

### 5.2 `btnReader_Click` - Akhrinta file-ka

```csharp
if (!File.Exists("modules.txt")) { ... return; }

OutputList.Items.Clear();
StreamReader reader = File.OpenText("modules.txt");

while (reader.Peek() != -1)
{
    OutputList.Items.Add(reader.ReadLine());
}
reader.Close();
```

- `File.Exists` hubiyaa file-ku jiro, si error aanu u dhicin.
- `Items.Clear()` nadiifiyaa liiska, si line-yadu u soo noqnoqon.
- `File.OpenText` furaa file-ka akhris awgeed.
- `Peek()` wuxuu soo celiyaa `-1` marka file-ku dhammaado (loop-ka ayuu joojiyaa).
- `ReadLine()` akhriyaa hal line.
- `Items.Add()` ku darta line-ka ListBox-ka.
- `Close()` xidhaa file-ka (muhiim ka hor Delete).

### 5.3 `btnDelete_Click` - Tirtirka file-ka

```csharp
File.Copy("modules.txt", "modules_backup.txt", true);
File.Delete("modules.txt");
OutputList.Items.Clear();
```

- `File.Copy(asal, cusub, true)` waxay samaysaa nuqul; `true` = haddii backup hore u jiray, beddel.
- `File.Delete` tirtiraa file-ka asalka ah.
- `Items.Clear()` ka saaraa waxa ListBox-ka ku jira.

### 5.4 `btnDeleteItems_Click` - Tirtirka item-ka

```csharp
OutputList.Items.RemoveAt(OutputList.SelectedIndex);

StreamWriter fileWriter = File.CreateText("modules.txt");
foreach (object oneItem in OutputList.Items)
{
    fileWriter.WriteLine(oneItem.ToString());
}
fileWriter.Close();
```

- `SelectedIndex == -1` macnaheedu waa waxba lama dooran.
- `RemoveAt(index)` ka saaraa item-ka ListBox-ka.
- `CreateText` dib ayuu u abuuraa file-ka (oo tirtiraa kii hore).
- `foreach` wuxuu ku qoraa items-ka hadhay file-ka.
- `Close()` wuu xidhaa file-ka.

---

## 6. Liiska function-yada la isticmaalay

| Function / Property | Class | Macnaha |
|---|---|---|
| `File.CreateText(path)` | `File` | Abuur file cusub oo qoraal ah, soo celiya `StreamWriter` |
| `File.OpenText(path)` | `File` | Fur file akhris awgeed, soo celiya `StreamReader` |
| `File.Exists(path)` | `File` | Hubi file-ku jiro (`true`/`false`) |
| `File.Copy(a, b, true)` | `File` | Nuqul ka samee file |
| `File.Delete(path)` | `File` | Tirtir file |
| `WriteLine(text)` | `StreamWriter` | Qor text iyo line cusub |
| `Close()` | `StreamWriter` / `StreamReader` | Xidh file-ka |
| `Peek()` | `StreamReader` | Eeg xarafka xiga; `-1` = dhammaad |
| `ReadLine()` | `StreamReader` | Akhri hal line |
| `Items.Add()` | `ListBox` | Ku dar item |
| `Items.Clear()` | `ListBox` | Tirtir dhammaan items |
| `Items.RemoveAt(i)` | `ListBox` | Tirtir item index-kiisu `i` yahay |
| `SelectedIndex` | `ListBox` | Index-ka item la doortay (`-1` = midna) |
| `MessageBox.Show()` | `MessageBox` | Muuji fariin |

---

## 7. Sida loo tijaabiyo

1. Riix **Start** (F5).
2. Riix **Reader**: waa inuu muujiyaa 6 line.
3. Dooro item, riix **Delete The Items File**: item-ka wuu baxayaa.
4. Riix **Deleting the File**: `modules.txt` waa la tirtiray, `modules_backup.txt` ayaa la sameeyay.
5. Dib u **Start** samee si file-ku mar kale u abuuramo.

---

## 8. Dhibaatooyin caadi ah

| Dhibaato | Sababta | Xalka |
|---|---|---|
| `FileNotFoundException` | File-ku ma jiro (Delete ayaa la riixay, ama Load ma shaqayn) | Dib u Start samee; hubi `Form1_Load_1` |
| File waa laga abuuri waayay | `Form1_Load` hore ayaa ku xiran Designer-ka, ma aha `Form1_Load_1` | Ku hay hal Load method oo keliya |
| `file is being used by another process` | `Close()` lama sameynin | Marwalba `Close()` ku dhammee |
| Items-ka liiska ayaa laba jeer soo baxay | `Items.Clear()` lama isticmaalin | Ku bilow `Clear()` ka hor akhrinta |

---

## 9. Fiiro gaar ah

- `Form1_Load_1` wuxuu file-ka **dib u abuuraa mar kasta oo barnaamijku furmo**, sidaa darteed isbeddellada (Delete Items) ma sii jiraan marka barnaamijka la xidho oo dib loo furo. Haddii aad rabto inay sii jiraan, ku dar `if (!File.Exists("modules.txt"))` ka hor `CreateText` gudaha Load.
- Magacyada Designer-ka (`btnReader`, `btnDelete`, `btnDeleteItems`, `OutputList`) waa inay ku qornaadaan **Properties > (Name)**.

---

*Mashruuc: Assigment Files | Chapter 4/5: Loops, Files, and Random Numbers*