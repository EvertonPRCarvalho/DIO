import { Component, Input, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";
import { Course } from "./courses/course";
import { CourseService } from "./courses/course.service";

@Component({
  templateUrl: './course-info.component.html'
})

export class  CourseInfoComponent implements OnInit{
  course!: Course;

  constructor(private activatedRoute: ActivatedRoute, private courseService: CourseService){}

  ngOnInit(): void{
    this.course = this.courseService.retrieveById(Number(this.activatedRoute.snapshot.paramMap.get('id')).subscribe({
      next: course => this.course = course,
      error: err => console.log('Error', err)
    }));
  }
}
