using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
     class DocumentWorker
    {
        virtual public void DocumentOpen()
        {
            Console.WriteLine("Документ открыт");
        }
        virtual public void EditDocument()
        {
            Console.WriteLine("Редактирование доступно в версии Pro");
        }
        virtual public void SaveDocument()
        {
            Console.WriteLine("Сохранение доступно в версии Pro");
        }
        public DocumentWorker()
        {
            

        }
    }
    class ProDocumentWorker : DocumentWorker
    {
        private string password;
        private string truePassword = "12345abc";

        public string Password { get => password; set => password = value; }

        public override void EditDocument()
        {
            
                Console.WriteLine("Документ отредактирован");
           
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранён в старом формате, сохранение в новых форматах доступно в версии Expert");
        }

    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранён в новом формате");
        }
    }
}
