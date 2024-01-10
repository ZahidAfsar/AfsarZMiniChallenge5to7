namespace AfsarZMiniChallenge5to7.Services.ChallengeSevenInt;

public class ChallengeSevenIntService : IChallengeSevenIntService
{
    public string IntReverse(string numOne)
    {
        int NumInt;
            bool isNumOne = int.TryParse(numOne, out NumInt);

            if(isNumOne){
             string reversed = "";
            for(int i = numOne.Length-1; i >= 0; i--)
            {
            reversed += numOne[i];
            };
            return $"{reversed}";
            }else{
            return $"Please use a number";
            }
    }
}
