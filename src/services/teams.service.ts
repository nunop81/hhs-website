import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { Team } from "../models/Team";

@Injectable({ providedIn: 'root' })
export class TeamsService {

    getTeams(): Team[] {
        let roboticsTeam: Team[] = [
            { firstName: 'Nathan', lastName: "Pereira", role: "Programmer" },
            { firstName: 'Mohith', lastName: "Patel", role: "Programmer" },
            { firstName: 'Joshua', lastName: "Moyer", role: "Electrician" },
            { firstName: 'Garen', lastName: "Demacia", role: "Engineer" },
            { firstName: 'Master', lastName: "Yi", role: "Designer" },
        ];
        return roboticsTeam;
    }

}