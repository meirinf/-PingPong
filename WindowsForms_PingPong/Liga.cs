using System;
namespace PingPong{

    public class Liga{
        private List<Jugador> Jugadores;

        public Liga(){
            Jugadores = new List<Jugador>();
        }
        public void NouJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }

        public Jugador getJugador(int i)
        {
            if (i < Jugadores.Count)
                return Jugadors[i];
            else
                return null;
        }

        public void delJugador(int i)
        {
            if (i < Jugadores.Count)
                Jugadors.RemoveAt(i);
        }

        public override String ToString()
        {
            String msg = "";

            foreach (Jugador jug in Jugadores)
                msg = msg + jug.ToString() + "\n";

            return msg;
        }
    }
}
