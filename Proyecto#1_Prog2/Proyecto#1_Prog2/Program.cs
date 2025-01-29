using System;
namespace Proyect
{
    class ItemBiblioteca(string titulo, string autor, string categoria, string publicacion)
    {
        public String autor = autor;
        public String titulo = titulo;
        public String categoria = categoria;
        public String publicacion = publicacion;

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Titulo: {titulo}. autor: {autor}. categoria: {categoria}. fecha de publicacion: {publicacion}.");
        }
    }
    class Libro(string titulo, string autor, string categoria, string publicacion) : ItemBiblioteca(titulo, autor, categoria, publicacion)
    {
        private readonly string TipoDeLectura = "Libro";

        public override void MostrarInfo()
        {
            Console.Write($"Tipo De lectura: {TipoDeLectura}. ");
            base.MostrarInfo();
        }

    }
    class Revista(string titulo, string autor, string categoria, string publicacion) : ItemBiblioteca(titulo, autor, categoria, publicacion)
    {
        private readonly string TipoDeLectura = "Revista";

        public override void MostrarInfo()
        {
            Console.Write($"Tipo De lectura: {TipoDeLectura}. ");
            base.MostrarInfo();
        }

    }
    class Program
    {
        public static void Main(String[] args)
        {
            Libro libro = new ("50 Sombras de grey", "Yo", "Erotica", "1992");
            libro.MostrarInfo();
            Console.WriteLine("");
            Revista revista = new ("Dou", "Bananirou", "Variedad", "2025");
            revista.MostrarInfo();
        }
    }
}