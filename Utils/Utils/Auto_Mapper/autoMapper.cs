using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Auto_Mapper
{
    public class FooI
    {
        public int baz;
    }

    public class BarI
    {
        public uint baz;
    }

    public class Foo
    {
        public string A { get; set; }
        public int B { get; set; }
    }

    public class Bar
    {
        public string A { get; set; }
        public int B { get; set; }
    }

    public class autoMapper
    {
        public autoMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Foo, Bar>();//mapeo completo
                cfg.CreateMap<FooI, BarI>().ForMember(dest => dest.baz, opt => opt.Condition(src => (src.baz >= 0))); //mapeo condicional
                //cfg.CreateMap<Foo, Bar>().ForMember(t => t.B, opt => opt.Ignore());//ignorar campos
            });
            

            IMapper mapper = config.CreateMapper();

            var foo = new Foo { A = "test", B = 100500 };
            
            var bar = mapper.Map<Bar>(foo);

            Console.WriteLine("foo type is {0}", foo.GetType());
            Console.WriteLine("foo_copy type is {0}", bar.GetType());

            Console.WriteLine("foo.A={0} foo.B={1}", foo.A, foo.B);
            Console.WriteLine("bar.A={0} bar.B={1}", bar.A, bar.B);


            var foo1 = new FooI { baz = -1 };
            var bar1 = mapper.Map<BarI>(foo1);

            Console.WriteLine("bar1.baz={0}", bar1.baz);

            var foo2 = new FooI { baz = 100 };
            var bar2 = mapper.Map<BarI>(foo2);


            Console.WriteLine("bar2.baz={0}", bar2.baz);
        }
    }
}
