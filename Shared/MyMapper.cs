using AutoMapper;

namespace Shared
{
    public static class MyMapper<TSource, TDestination>
    {
        private static Mapper _myMapper = new Mapper(new MapperConfiguration(cfg =>
                    cfg.CreateMap<TSource, TDestination>()
                ));

        public static TDestination ObjectMap(TSource source)
        {
            return _myMapper.Map<TDestination>(source);
        }

        public static List<TDestination> ListMap(List<TSource> source)
        {
            List<TDestination> destinations = new List<TDestination>();

            source.ForEach(x => { destinations.Add(ObjectMap(x)); });

            return destinations;
        }
    }
}
