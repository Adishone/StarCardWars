import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CrewMemberCardComponent } from './crew-member-card.component';

describe('CrewMemberCardComponent', () => {
  let component: CrewMemberCardComponent;
  let fixture: ComponentFixture<CrewMemberCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CrewMemberCardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CrewMemberCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
