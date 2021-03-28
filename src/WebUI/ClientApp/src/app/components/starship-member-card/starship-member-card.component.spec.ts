import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StarshipMemberCardComponent } from './starship-member-card.component';

describe('StarshipMemberCardComponent', () => {
  let component: StarshipMemberCardComponent;
  let fixture: ComponentFixture<StarshipMemberCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StarshipMemberCardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StarshipMemberCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
