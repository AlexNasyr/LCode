namespace LCode.Model {
    public interface ILcRepository {
        Task<LcResponce[]> GetQueries();
    }
}
