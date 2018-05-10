using SunsetHotelSystem.Dominio.IRepositorio;
using SunsetHotelSystem.Infraestructura.Datos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace SunsetHotelSystem.Infraestructura.IoC {
    public sealed class FabricaIoC {
        private static readonly FabricaIoC _container = new FabricaIoC();
        private readonly IUnityContainer _unityContainer;

        private FabricaIoC() {
            _unityContainer = new Unity.UnityContainer();
            _unityContainer.RegisterType<IRepositorioHabitacion, RepositorioHabitacion>();
            _unityContainer.RegisterType<IRepositorioTipoHabitacion, RepositorioTipoHabitacion>();
            _unityContainer.RegisterType<IRepositorioReserva, RepositorioReserva>();
            _unityContainer.RegisterType<IRepositorioHome, RepositorioHome>();
        }//Fin del constructor.
        public static FabricaIoC Container {
            get { return _container; }
        }//Fin del método Container.
        public TService Resolver<TService>() {
            return _unityContainer.Resolve<TService>();
        }//Fin del método Resolver.
    }//Fin de la clase FabricaIoC.
}//Fin del namespace.