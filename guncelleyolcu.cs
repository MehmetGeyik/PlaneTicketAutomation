using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uçak_Bileti_Otomasyonu
{
    class Guncelleyolcu
    {
        // Gözlemleyicilerimizi tutacağımız listemiz.
        private List<Observer> _observers = new List<Observer>();
        private String message;
        private Boolean changed;
        
        
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        private void Notify()
        {
            /* Herhangi bir değişiklik olduğunda gözlemleyicilerimizin Update metotunu tetikleterek istenilen aksiyonu gerçekleştirebiliriz.
            Örneğin: Kullanıcılara e-posta atmak gibi düşünebilirsiniz.*/
            
            List<Observer> _observersLocal = null;
            if (!changed)
                return;
            _observersLocal = new List<Observer>(this._observers);
            this.changed = false;

            _observers.ForEach(o => { o.Update(); });
        }

        public void Koltukupdate()
        {
            
            // Koltuk değiştirildiğinde gözlemcilerimize bildiriyoruz.
            this.Notify();
        }
        
    }
}
