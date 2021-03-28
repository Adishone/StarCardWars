import { Component, Input, OnInit } from '@angular/core';
import { CrewMember } from 'src/app/models/crew-member.model';

@Component({
  selector: 'app-crew-member-card',
  templateUrl: './crew-member-card.component.html',
  styleUrls: ['./crew-member-card.component.css']
})
export class CrewMemberCardComponent implements OnInit {
  @Input() crewMember: CrewMember;
  @Input() isLoading = false;
  constructor() { }

  ngOnInit(): void {
  }

}
