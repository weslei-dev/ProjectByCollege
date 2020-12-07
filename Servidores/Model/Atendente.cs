using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace Servidores.Model
{
    public class Atendente
    {
        public event EventHandler Atender;

        public Atendente()
        {
            _timer = new Timer();            
            _timer.Elapsed += (s, e) => Atender?.Invoke(s, e);
        }

        public string Nome { get; set; }
        public TimeSpan TempoAtendimento { get; set; }

        public void IniciarAtendimento()
        {
            _timer.Interval = TempoAtendimento.TotalMilliseconds;
            _timer.Enabled = true;
        }

        private Timer _timer;        
    }
}
