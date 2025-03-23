import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { Team } from '../../../models/Team';
import { TeamsService } from '../../../services/teams.service';

@Component({
  selector: 'team',
  imports: [CommonModule, RouterModule],
  standalone: true,
  templateUrl: './team.component.html',
  styleUrl: './team.component.css'
})
export class TeamComponent implements OnInit {
  teams: Team[] | null = null;

  constructor(private teamsSvc: TeamsService) { }

  ngOnInit(): void {
    this.teams = this.teamsSvc.getTeams();
  }
}
