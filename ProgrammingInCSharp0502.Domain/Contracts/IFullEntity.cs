namespace ProgrammingInCSharp0502.Domain.Contracts;

internal interface IFullEntity<T>: IEntity<T>, ICreatableEntity , IDeletableEntity
{
}
