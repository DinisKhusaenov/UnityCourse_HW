public interface IEnemyVisitor 
{
    void Visit(Ork ork);
    void Visit(Human human);
    void Visit(Elf elf);
    void Visit(Enemy enemy);

    void Reduce(Ork ork);
    void Reduce(Human human);
    void Reduce(Elf elf);
    void Reduce(Enemy enemy);
}
