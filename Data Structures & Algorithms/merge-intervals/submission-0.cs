public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length <= 1) 
            return intervals;
        
        // Trier les intervalles par leur début
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        
        var merged = new List<int[]>();
        var current = intervals[0];
        
        for (int i = 1; i < intervals.Length; i++) {
            // Si l'intervalle actuel chevauche avec le suivant
            if (current[1] >= intervals[i][0]) {
                // Fusionner en prenant le max des fins
                current[1] = Math.Max(current[1], intervals[i][1]);
            } else {
                // Pas de chevauchement, ajouter l'intervalle courant
                merged.Add(current);
                current = intervals[i];
            }
        }
        
        // Ne pas oublier d'ajouter le dernier intervalle
        merged.Add(current);
        
        return merged.ToArray();
    }
}