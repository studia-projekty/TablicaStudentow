internal class Program
{
    private static void Main(string[] args)
    {
            struct_student s1;  //"struct_student" pojawia sie w tym miejsu, żeby wskazać jaki to jest typ zmiennej tak jak np. "int" albo "string", a potem jest nazwa zmiennej "s1"
            s1.imie = "Adam"; // dopisuje Adam do pola "imie" struktury
            s1.wiek = 35; // dopisuje 35 do pola "wiek" struktury 

            struct_student s2;
            s2.imie = "Piotr";
            s2.wiek = 17;

            struct_student s3;
            s3.imie = "Bolesław";
            s3.wiek = 100;       
                
            struct_student[] studenci = {s1, s2, s3};

            foreach(struct_student x in studenci)
                {
                    Console.WriteLine("Imie: " + x.imie + ", Wiek: " + x.wiek);
                }
            Console.WriteLine();
            Console.WriteLine($"Średnia wieku: " + ObliczSredniaWieku(studenci));
            //Console.WriteLine(studenci[0].wiek); //to by wydrukowało z tablicy pozycje 0, czyli s1.
    }
// ################ METODY I INNE TAKIE TAM SE ###############

static double ObliczSredniaWieku(struct_student[] daneStudentow) 
// static - bo musi byc, 
     //double - typ danych jakie zostaną zwrócone, 
            //ObliczSredniaWieku - nazwa metody, 
                                //struct_student[] - typ danych, czyli tablica stworzona na strukturze struct_student
                                                //daneStudentow - nazwa zmiennej
        {
            double ilosc = 0;
            double suma = 0;
            foreach(struct_student x in daneStudentow)
            {
                ilosc = ilosc + 1;
                suma = suma + x.wiek;
            }
            double wynik = suma / ilosc;
            return  wynik;
        }
struct struct_student
    {
        public string imie;
        public int wiek;
    }

}