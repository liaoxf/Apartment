using Autofac;
using System;
using System.Linq;
using System.Reflection;

namespace Apartment.Common.Autofac
{
    public class AutofacService
    {
        private static object lockHelper = new object();
        private static IContainer _instance;
        private static ContainerBuilder _builder;

        AutofacService(IContainer container)
        {
            _instance = container;
        }

        /// <summary>
        /// 注入接口(Mvc)
        /// </summary>
        /// <param name="assemblyNames"></param>
        /// <returns></returns>
        public static IContainer Register(params string[] assemblyNames)
        {
            var builder = CreateInstance(_builder);

            assemblyNames.ToList().ForEach(name =>
            {
                builder.RegisterAssemblyTypes(Assembly.Load(name), Assembly.Load(name))
                  .AsImplementedInterfaces();
            });
            _instance = builder.Build();
            return _instance;
        }


        /// <summary>
        /// 注入接口
        /// </summary>
        /// <param name="assemblyNames"></param>
        /// <returns></returns>
        public static ContainerBuilder RegisterInterface(params string[] assemblyNames)
        {
            var builder = CreateInstance(_builder);

            var assembly = Assembly.GetExecutingAssembly();

            assemblyNames.ToList().ForEach(name =>
            {
                var interfaceFactory = Assembly.Load(name);
                builder.RegisterAssemblyTypes(interfaceFactory, interfaceFactory)
                  .AsImplementedInterfaces();
            });

            return builder;
        }

        /// <summary>
        /// 反转接口
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            return _instance.Resolve<T>();
        }

        /// <summary>
        /// 构造容器
        /// </summary>
        public static IContainer Instance
        {
            get { return _instance; }
        }

        /// <summary>
        /// 多线程加锁
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_instance"></param>
        /// <returns></returns>
        public static T CreateInstance<T>(T _instance)
        {
            if (_instance == null)
            {
                lock (lockHelper)
                {
                    if (_instance == null)
                    {
                        _instance = (T)Activator.CreateInstance(typeof(T));
                    }
                }
            }
            return _instance;
        }
    }

    /// <summary>
    /// 注入接口
    /// </summary>
    public interface IRegister
    {
        void Install();
    }

    public class Register : IRegister
    {
        public Register()
        {
            Install();
        }
        //子类必须重写
        public virtual void Install()
        {

        }
    }
}
