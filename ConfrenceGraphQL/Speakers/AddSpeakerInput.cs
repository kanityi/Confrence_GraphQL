namespace ConfrenceGraphQL.Speakers
{
    public record AddSpeakerInput(
        string Name,
        string? Bio,
        string? Website
    );

}