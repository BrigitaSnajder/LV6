using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.AddNote(new Note("Note1", "Text1"));
            notebook.AddNote(new Note("Note2", "Text2"));
            notebook.AddNote(new Note("Note3", "Text3"));
            IAbstractIterator iterator = notebook.GetIterator();
            for(Note note = iterator.First(); !iterator.IsDone; note = iterator.Next())
            {
                note.Show();
            }

            Box box = new Box();
            box.AddProduct(new Product("Product1", 10.99));
            box.AddProduct(new Product("Product2", 5));
            box.AddProduct(new Product("Product3", 12.8));
            IAbstractIteratorBox iteratorbox = box.GetIterator();
            for (Product product = iteratorbox.First(); !iteratorbox.IsDone; product = iteratorbox.Next())
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
