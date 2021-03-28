import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-crew-member-card',
  templateUrl: './crew-member-card.component.html',
  styleUrls: ['./crew-member-card.component.css']
})
export class CrewMemberCardComponent implements OnInit {
  public isLoading = true;
  constructor() { }

  ngOnInit(): void {
  }

}
