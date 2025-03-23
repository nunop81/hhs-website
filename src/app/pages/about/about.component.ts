import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'about',
  imports: [CommonModule, RouterModule],
  standalone: true,
  templateUrl: './about.component.html',
  styleUrl: './about.component.css'
})
export class AboutComponent implements OnInit {
  title = 'about';

  constructor() { }

  ngOnInit(): void {
  }
}
