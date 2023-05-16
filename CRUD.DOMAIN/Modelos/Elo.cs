using LinqToDB.Mapping;

namespace CRUD.Modelos
{
    public enum Elo
    {
        [MapValue("Ferro")]
        Ferro,
        [MapValue("Bronze")]
        Bronze,
        [MapValue("Prata")]
        Prata,
        [MapValue("Ouro")]
        Ouro,
        [MapValue("Platina")]
        Platina,
        [MapValue("Diamante")]
        Diamante,
        [MapValue("Mestre")]
        Mestre,
        [MapValue("GM")]
        GM,
        [MapValue("Desafiante")]
        Desafiante

    }
}
