using System;

public class HelloWorld
{
    static public void Main ()
    {
     familyhobi ak = new familyhobi();
     familyhobi ayah = new Ayah();
     familyhobi ibu = new Ibu();
     familyhobi anak = new Anak();
     familyhobi adik= new Adik();
     
     familydata ayahku = new familydata("Arif mustofa",40,+6283817949240);
    familydata ibuku = new familydata("poniatul laili",39,+6283817949240);
    familydata aku = new familydata("Muhammad Kholili",16,+6283817949240);
familydata adiku = new familydata("dewi sastro rahayu ningrat",11,+6283817949240);
     Console.WriteLine("data ayah:\n"+ayahku.nama+"\n"+ayahku.umur+"\n"+ayahku.nohp);
     ayah.Hobi();
   Console.WriteLine("data ibu:\n"+ibuku.nama+"\n"+ibuku.umur+"\n"+ibuku.nohp);
     ibu.Hobi();
     Console.WriteLine("data anak:\n"+aku.nama+"\n"+aku.umur+"\n"+aku.nohp);
     anak.Hobi();
     
Console.WriteLine("data adik:\n"+adiku.nama+"\n"+adiku.umur+"\n"+adiku.nohp);
     adik.Hobi();
     

    }
    class familydata
    {
        public string nama;
        public int umur;
        public long nohp;
        
        public familydata(string Nama,int Umur,long Nohp)
        {
            nama = Nama;
            umur = Umur;
            nohp = Nohp;
        }
       
        
        
    }
    class familyhobi 
    {
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Ayah:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("jalanjalan");
        }
    }
    class Ibu:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("jalanjalan");
        }
    }
    class Anak:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("jalanjalan dan ngonten");
        }
    }
class Adik:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("jalanjalan");
        }
    }
    

}
