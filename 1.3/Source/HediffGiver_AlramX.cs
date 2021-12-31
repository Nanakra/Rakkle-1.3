using Verse;

namespace Rakkle
{
    public class HediffGiver_AlramX : HediffGiver
    {
        public override void OnIntervalPassed(Pawn pawn, Hediff cause)
        {
            if (Rand.MTBEventOccurs(this.mtbDays, 60000f, 60f) && base.TryApply(pawn, null))
            {

            }
        }
        public float mtbDays;
    }
}
