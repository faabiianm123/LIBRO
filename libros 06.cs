public class Libros {
// Atributos 
private String ISBN="";
private String Titulo=""; 
private String Autor="";
private int numpaginas;

//Metodos
public void ConsultarISBN () {
   Console.WriteLine (this.ISBN); 
}
public void ConsultarTitulo () {
   Console.WriteLine  (this.Titulo);
}
public void Consultarautor () {
  Console.WriteLine ( this.Autor);
}
public int Consultarnumpaginas () {
   return this.numpaginas; 
}
public void  SetISBN (string ISBN) {
    this.ISBN = ISBN;
}
public void SetTitulo (string Titulo) {
    this.Titulo = Titulo;
}
public void SetAutor (string Autor) {
    this.Autor = Autor;
}
public void Setnumpaginas (int numpaginas) {
    this.numpaginas = numpaginas; }
public void tostring (){
   Console.WriteLine("El libro "+this.Titulo+" del autor "+this.Autor+" tiene "+this.numpaginas+" paginas");
}
 }
 /Creamos una clase libro
public class Libreta{

//Creamos un producto Main y creamos dos libros 
 public static void Main(string[] args){

    Libros Pinocho= new Libros();
    Pinocho.Setnumpaginas(169);
    Pinocho.SetISBN("312546764532");
    Pinocho.SetAutor("Carlos collodi");
    Pinocho.SetTitulo("Pinocho");
    Pinocho.tostring();

    Libros NACHO = new Libros ();
    NACHO.Setnumpaginas(50);
    NACHO.SetISBN("312897654323");
    NACHO.SetAutor("Melanio Hernandez");
   NACHO.SetTitulo("Nacho");
    NACHO.tostring();
  
if (NACHO.Consultarnumpaginas() >= Pinocho.Consultarnumpaginas())  {

   Console.WriteLine("Pinocho tiene mas paginas");
}
   else
   {
    Console.WriteLine("NACHO tiene menos pagina");
   }
   }

 }