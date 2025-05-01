namespace Modelo_ToDo {
    
    public class Tarea {
        public int TareaID { get;  set; }
        public string Descripcion { get;  set; }
        public int Duracion { get;  set; }

        public Tarea(int id, string descr, int dura) {
            this.TareaID = id;
            this.Descripcion = descr;
            this.Duracion = dura;
        }    
    }

    public class Manejo {
        private List<Tarea> tareasPendientes= new List<Tarea>();
        private List<Tarea> tareasRealizadas = new List<Tarea>();
        private int Id = 1;

        public void crearTareas(int cantidad) {
            Random rand = new Random();
            string[] descrp = {"Revisar Inventario", "Actualizar Base de Datos", "Optimizar Codigo"};

            for (int i = 0; i < cantidad; i++)
            {
                string desc = descrp[rand.Next(descrp.Length)];
                int dur = rand.Next(10, 101);
                tareasPendientes.Add(new Tarea(Id++, desc, dur));
            }

        }

        public void MoverTarea(int id) {
            Tarea tarea = tareasPendientes.Find(t => t.TareaID == id);
            if (tarea != null) {
                tareasRealizadas.Add(tarea);
                tareasPendientes.Remove(tarea);
                Console.WriteLine($"La tarea {tarea.TareaID} fue marcada como realizada");
            } else {
                Console.WriteLine("la Id no fue encontrada");
            }
        }

        public void bucarPorLetra(string texto) {
            var encontradas = tareasPendientes.FindAll(t => t.Descripcion.Contains(texto, StringComparison.CurrentCultureIgnoreCase));
            if (encontradas.Count > 0)
            {
                Console.WriteLine("Tareas pendientes encontradas");
                foreach (var item in encontradas)
                {
                    Console.WriteLine($"id: {item.TareaID}");
                    Console.WriteLine($"Descripcion: {item.Descripcion}");
                    Console.WriteLine($"Duracion: {item.Duracion}");
                }
            } else {
                Console.WriteLine("No se encontro tareas");
            }
        }

        public void MostrarTodas() {
            Console.WriteLine("===== Tareas Pendientes =====");
            if (tareasPendientes.Count > 0) {
                foreach (var item in tareasPendientes)
                {
                    Console.WriteLine($"id: {item.TareaID}");
                    Console.WriteLine($"Descripcion: {item.Descripcion}");
                    Console.WriteLine($"Duracion: {item.Duracion}");
                    Console.WriteLine("-----------------------------");
                }
            } else {
                Console.WriteLine("No hay tareas pendientes");
            }
            Console.WriteLine("-----------------------------");

            Console.WriteLine("===== Tareas Realizadas =====");
            if (tareasRealizadas.Count > 0) {
                foreach (var item in tareasRealizadas)
                {
                    Console.WriteLine($"id: {item.TareaID}");
                    Console.WriteLine($"Descripcion: {item.Descripcion}");
                    Console.WriteLine($"Duracion: {item.Duracion}");
                    Console.WriteLine("-----------------------------");
                }
            } else {
                Console.WriteLine("No hay tareas Realizadas");
            }
        }
    }

}