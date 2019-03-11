using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Grade 
    {
        private string subject;
        private DateTime data;
        private double worth;

        public double Worth
        {
            get { return worth; }
            set { worth = value; }
        }


        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }


        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public Grade()  //czy jeżeli ta klasa dziedziczy z Student to czy Student wpisuje wartości z klasy z której ona dziedziczy?
        {
            subject = "none";
            data = new DateTime();
            worth = 0.0;
        }
        public Grade(string subject_, DateTime data_, double worth_)
        {    
            subject = subject_;
            data = data_;
            worth = worth_;
            
        }

        public override string ToString()
        {
            return  $" Subject: {subject}, Data: {data}, Worth: {worth}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
