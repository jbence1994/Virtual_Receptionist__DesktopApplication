namespace virtual_receptionist.Model.Interfaces
{
    /// <summary>
    /// Adatmanipulációt objektumokon leíró interfész
    /// </summary>
    /// <typeparam name="T">Típus</typeparam>
    public interface IManipulable<T> where T : class
    {
        /// <summary>
        /// Új elem létrehozása
        /// </summary>
        /// <param name="item">Elem</param>
        void Create(T item);

        /// <summary>
        /// Meglévő elem módosítása
        /// </summary>
        /// <param name="item">Elem</param>
        void Update(T item);

        /// <summary>
        /// Meglévő elem törlése
        /// </summary>
        /// <param name="item">Elem</param>
        void Delete(T item);
    }
}
