using System;

public class Solution
{
    public int solution(string skill, string[] skill_trees)
    {
        int answer = 0;

        foreach (string _skills in skill_trees)
        {
            int i = 0;

            foreach (char _skill in _skills)
            {
                if (skill.Contains(_skill) && skill[i] == _skill)
                    i++;
                else if (skill.Contains(_skill) && skill[i] != _skill)
                    goto Exit;
            }

            answer++;
            Exit:;         
        }
        return answer;
    }
}
