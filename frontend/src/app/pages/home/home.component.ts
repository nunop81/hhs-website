import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Team } from '../../../models/Team';
import { TeamsService } from '../../../services/teams.service';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';


@Component({
  selector: 'home',
  imports: [CommonModule, RouterModule, FormsModule],
  standalone: true,
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class AppComponent implements OnInit {
  teams: Team[] | null = null;
  capabilities: Capability[] = [];

  student = {
    firstName: "Nathan",
    lastName: "Pereira",
    skills: [
      "python", "c#", "Java"
    ]
  }
  students: Student[] = [];

  studentName!: string;
  studentRole!: string;
  studentEmail!: string;

  showStudentName() {
    alert(this.studentName);
  }

  setStudent() {
    this.studentName = "Nathan";
    this.studentRole = "Programmer";
    this.studentEmail = "Nathanp@outlook.com";
  }

  clearStudent() {
    this.studentName = "";
    this.studentRole = "";
    this.studentEmail = "";
  }

  addStudent() {
    let newStudent = {
      studentName: this.studentName,
      studentRole: this.studentRole,
      studentEmail: this.studentEmail
    };
    this.students.push(newStudent);
  }

  constructor(private teamsSvc: TeamsService) { }

  ngOnInit(): void {
    this.teams = this.teamsSvc.getTeams();

    // let cap = new Capability();
    // cap.title = "Nathan 1";
    // cap.desc = "We use Python and Java to write AI algorithms that drive our robots with precision.";
    // this.capabilities.push(cap);

    // cap = new Capability();
    // cap.title = "Capability 2";
    // cap.desc = "We use Python and Java to write AI algorithms that drive our robots with precision.";
    // this.capabilities.push(cap);

    // cap = new Capability();
    // cap.title = "Capability 3";
    // cap.desc = "We use Python and Java to write AI algorithms that drive our robots with precision.";
    // this.capabilities.push(cap);
  }
}

class Student {
  studentName!: string;
  studentRole!: string;
  studentEmail!: string;
}

class Capability {
  title: string = "";
  desc: string = "";
}