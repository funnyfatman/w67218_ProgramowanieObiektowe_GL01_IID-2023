namespace Lab5_6;


    public interface IBaseRepository<T, TEntity> where T : IEntity<TEntity>
    {
        void Create(T entity);
        void Update(T entity);
        void GetAll();
        T Get(TEntity id);
        void Delete(TEntity id);
    }
