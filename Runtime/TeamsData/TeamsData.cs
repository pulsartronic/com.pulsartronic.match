using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pulsartronic;

[System.Serializable]
public class ProgressionCurve {
    public float min;
    public float max;
    public AnimationCurve curve;

    public float GetValue(float step) {
        return this.min + (this.max - this.min) * this.curve.Evaluate(step);
    }
}

public class TeamsData : NonPersistentSingleton<TeamsData> {
    public TeamEquipments equipments;

    public ProgressionCurve speed_curve;

    public JSONArray teams = new JSONArray();

    protected override void Awake() {
        base.Awake();

        this.teams.Clear();

        float max_level = 23f;

        JSONObject team_0 = this.DefaultTeam(0f / max_level);
        team_0.Set("name", "Ice Blasters");
        team_0.Set("ac", "I.B.");
        this.teams.Add(team_0);

        JSONObject team_1 = this.DefaultTeam(1f / max_level);
        team_1.Set("name", "Kamikaze United");
        team_1.Set("ac", "K.U.");
        this.teams.Add(team_1);

        JSONObject team_2 = this.DefaultTeam(2f / max_level);
        team_2.Set("name", "Blue Island");
        team_2.Set("ac", "B.I.");
        this.teams.Add(team_2);

        JSONObject team_3 = this.DefaultTeam(3f / max_level);
        team_3.Set("name", "Poison Rebels");
        team_3.Set("ac", "P.R.");
        this.teams.Add(team_3);

        JSONObject team_4 = this.DefaultTeam(4f / max_level);
        team_4.Set("name", "Wild Stingers");
        team_4.Set("ac", "W.S.");
        this.teams.Add(team_4);

        JSONObject team_5 = this.DefaultTeam(5f / max_level);
        team_5.Set("name", "Game Lockers");
        team_5.Set("ac", "G.L.");
        this.teams.Add(team_5);

        JSONObject team_6 = this.DefaultTeam(6f / max_level);
        team_6.Set("name", "Ghost Tigers");
        team_6.Set("ac", "G.T.");
        this.teams.Add(team_6);

        JSONObject team_7 = this.DefaultTeam(7f / max_level);
        team_7.Set("name", "Shockwave Ducks");
        team_7.Set("ac", "S.D.");
        this.teams.Add(team_7);

        JSONObject team_8 = this.DefaultTeam(8f / max_level);
        team_8.Set("name", "Chair Blasters");
        team_8.Set("ac", "C.B.");
        this.teams.Add(team_8);

        JSONObject team_9 = this.DefaultTeam(9f / max_level);
        team_9.Set("name", "Wind Sharpshooters");
        team_9.Set("ac", "W.S.");
        this.teams.Add(team_9);

        JSONObject team_10 = this.DefaultTeam(10f / max_level);
        team_10.Set("name", "Skull Heroes");
        team_10.Set("ac", "S.H.");
        this.teams.Add(team_10);

        JSONObject team_11 = this.DefaultTeam(11f / max_level);
        team_11.Set("name", "Militant Pirates");
        team_11.Set("ac", "M.P.");
        this.teams.Add(team_11);

        JSONObject team_12 = this.DefaultTeam(12f / max_level);
        team_12.Set("name", "Spinning Tornadoes");
        team_12.Set("ac", "S.T.");
        this.teams.Add(team_12);

        JSONObject team_13 = this.DefaultTeam(13f / max_level);
        team_13.Set("name", "Shooting Lightning");
        team_13.Set("ac", "S.L.");
        this.teams.Add(team_13);

        JSONObject team_14 = this.DefaultTeam(14f / max_level);
        team_14.Set("name", "Reptile Mavericks");
        team_14.Set("ac", "R.M.");
        this.teams.Add(team_14);

        JSONObject team_15 = this.DefaultTeam(15f / max_level);
        team_15.Set("name", "Pink Tigers");
        team_15.Set("ac", "P.T.");
        this.teams.Add(team_15);

        JSONObject team_16 = this.DefaultTeam(16f / max_level);
        team_16.Set("name", "Extreme Mutants");
        team_16.Set("ac", "E.M.");
        this.teams.Add(team_16);

        JSONObject team_17 = this.DefaultTeam(17f / max_level);
        team_17.Set("name", "Retro Busters");
        team_17.Set("ac", "R.B.");
        this.teams.Add(team_17);

        JSONObject team_18 = this.DefaultTeam(18f / max_level);
        team_18.Set("name", "Moose Soldiers");
        team_18.Set("ac", "M.S.");
        this.teams.Add(team_18);

        JSONObject team_19 = this.DefaultTeam(19f / max_level);
        team_19.Set("name", "Mighty Panthers");
        team_19.Set("ac", "M.P.");
        this.teams.Add(team_19);

        JSONObject team_20 = this.DefaultTeam(20f / max_level);
        team_20.Set("name", "Rhino Bandits");
        team_20.Set("ac", "R.B.");
        this.teams.Add(team_20);

        JSONObject team_21 = this.DefaultTeam(21f / max_level);
        team_21.Set("name", "Samurai Blockers");
        team_21.Set("ac", "S.B.");
        this.teams.Add(team_21);

        JSONObject team_22 = this.DefaultTeam(22f / max_level);
        team_22.Set("name", "Fire Cyborgs");
        team_22.Set("ac", "F.C.");
        this.teams.Add(team_22);

        JSONObject team_23 = this.DefaultTeam(23f / max_level);
        team_23.Set("name", "Carnivore Mashers");
        team_23.Set("ac", "C.M.");
        this.teams.Add(team_23);
    }

    public JSONObject DefaultTeam(float level) {
        var rnd = new System.Random(34);

        JSONObject team = new JSONObject();

        float avg = 3f + 6f * level + (float) rnd.NextDouble();
        team.Set("avg", avg);

        JSONArray players = new JSONArray();
        team.Set("players", players);

        JSONObject player_1 = new JSONObject();
        player_1.Set("prefab", 1); // prefab index
        player_1.Set("speed", this.speed_curve.GetValue(level));
        //players.Add(player_1);

        JSONObject player_2 = new JSONObject();
        player_2.Set("prefab", 1); // prefab index
        player_2.Set("speed", this.speed_curve.GetValue(level));
        //players.Add(player_2);

        JSONObject player_3 = new JSONObject();
        player_3.Set("prefab", 1); // prefab index
        player_3.Set("speed", this.speed_curve.GetValue(level));
        //players.Add(player_3);

        JSONObject player_4 = new JSONObject();
        player_4.Set("prefab", 1); // prefab index
        player_4.Set("speed", this.speed_curve.GetValue(level));
        //players.Add(player_4);

        JSONObject player_5 = new JSONObject();
        player_5.Set("prefab", 1); // prefab index
        player_5.Set("speed", this.speed_curve.GetValue(level));
        //players.Add(player_5);

        JSONObject player_6 = new JSONObject();
        player_6.Set("prefab", 1); // prefab index
        player_6.Set("speed", this.speed_curve.GetValue(level));
        //players.Add(player_6);

        JSONObject player_7 = new JSONObject();
        player_7.Set("prefab", 0); // prefab index
        player_7.Set("speed", 0.35f + this.speed_curve.GetValue(level));
        //players.Add(player_7);

        JSONObject player_8 = new JSONObject();
        player_8.Set("prefab", 0); // prefab index
        player_8.Set("speed", 0.35f + this.speed_curve.GetValue(level));
        //players.Add(player_8);

        JSONObject player_9 = new JSONObject();
        player_9.Set("prefab", 2); // prefab index
        player_9.Set("speed", 0.75f + this.speed_curve.GetValue(level));
        //players.Add(player_9);

        JSONObject player_10 = new JSONObject();
        player_10.Set("prefab", 0); // prefab index
        player_10.Set("speed", 0.35f + this.speed_curve.GetValue(level));
        //players.Add(player_10);

        JSONObject player_11 = new JSONObject();
        player_11.Set("prefab", 2); // prefab index
        player_11.Set("speed", 0.75f + this.speed_curve.GetValue(level));
        //players.Add(player_11);

        JSONObject player_12 = new JSONObject();
        player_12.Set("prefab", 0); // prefab index
        player_12.Set("speed", 0.35f + this.speed_curve.GetValue(level));
        //players.Add(player_12);

        JSONObject player_13 = new JSONObject();
        player_13.Set("prefab", 0); // prefab index
        player_13.Set("speed", 0.35f + this.speed_curve.GetValue(level));
        //players.Add(player_13);

        JSONObject player_14 = new JSONObject();
        player_14.Set("prefab", 2); // prefab index
        player_14.Set("speed", 0.75f + this.speed_curve.GetValue(level));
        //players.Add(player_14);

        JSONObject player_15 = new JSONObject();
        player_15.Set("prefab", 2); // prefab index
        player_15.Set("speed", 8f);
        //players.Add(player_15);

        /*
        players.Add(player_8);
        players.Add(player_1);
        players.Add(player_9);
        players.Add(player_2);
        players.Add(player_10);
        players.Add(player_3);
        players.Add(player_11);
        players.Add(player_4);
        players.Add(player_12);
        players.Add(player_5);
        players.Add(player_13);
        players.Add(player_6);
        players.Add(player_14);
        players.Add(player_7);
        players.Add(player_15);
        */
        
        players.Add(player_1);
        players.Add(player_2);
        players.Add(player_3);
        players.Add(player_4);
        players.Add(player_5);
        players.Add(player_6);
        players.Add(player_7);
        players.Add(player_8);
        players.Add(player_9);
        players.Add(player_10);
        players.Add(player_11);
        players.Add(player_12);
        players.Add(player_13);
        players.Add(player_14);
        players.Add(player_15);
        return team;
    }
}
