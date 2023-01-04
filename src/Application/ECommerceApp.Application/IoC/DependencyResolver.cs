using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Application.IoC
{
    public class DependencyResolver : Module
        
    {
        protected override void Load(ContainerBuilder builder)
        {  // IoC : INTERFACE ÇAĞIRDIĞIM ZAMAN BANA ONUN CONCRETE YAPISINI GETİRMESİ GEREKTİĞİ İŞLEMİ BURADA SÖYLÜYORUM
           // builder.RegisterType<BaseRepo>().As<IBaseRepo>().InstancePerLifeTimeScope();
           // program.cs tarafında yapacağım eklemeleri buradan yapabilirim.
           // Örnek olarak automapper eklenmesini buradan yapabilirim.


            base.Load(builder);
        }
    }
}
