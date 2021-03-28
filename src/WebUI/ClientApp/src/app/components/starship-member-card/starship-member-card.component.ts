import { Component, Input, OnInit } from '@angular/core';
import { Starship } from 'src/app/models/starship.model';

@Component({
  selector: 'app-starship-member-card',
  templateUrl: './starship-member-card.component.html',
  styleUrls: ['./starship-member-card.component.css']
})
export class StarshipMemberCardComponent implements OnInit {
  @Input() starship: Starship;
  @Input() isLoading = false;
  constructor() { }

  ngOnInit(): void {
  }

}
