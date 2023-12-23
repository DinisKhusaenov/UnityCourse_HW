public class WhiteBall : Ball
{
    private const ColorsEnum _color = ColorsEnum.White;

    public override ColorsEnum GetColor()
    {
        return _color;
    }
}
