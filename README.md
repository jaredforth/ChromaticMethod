# Software Requirements Specification
## for
# The Chromatic Method

**Prepared by Jared Forth**

**Fort Hays State University**

**2/19/2018**

## Table of Contents

| Table of Contents        |
| --- |
|         [**1. Introduction**  ](#1-introduction)     |
|         [1.1 Purpose](#11-purpose)      |
|         [1.2 Project Scope](#12-project-scope)      |
|         [1.3 References](#13-references)      |
|         [**2. Overall Description**](#2-overall-description)        |
|         [2.1 Product Perspective](#21-product-perspective)     |
|         [2.2. User Classes and Characteristics](#22-user-classes-and-characteristics)      |
|         [2.3 Operating Environment](#23-operating-environment)       |
|         [**3. System Features**](#3-system-features)        |
|         [3.1 Key Analyzer](#31-key-analyzer)     |
|         [3.2 Chord Finder](#32-chord-finder)        |
|         [3.3. Scale Finder](#33-scale-finder)       |
|         [**4. External Interface Requirements**](#4-external-interface-requirements)        |
|         [4.1 User Interfaces](#41-user-interfaces)       |
|         [**5. Quality Attributes**](#5-quality-attributes)       |
|         [5.1 Usability](#51-usability)      |
|         [5.2 Performance](#52-performance)       |
|         [**6. UML Diagrams**](#6-uml-diagrams)       |
|         [6.1 Use Case Diagram](#61-use-case-diagram)       |
|         [6.2 Component Diagram](#62-component-diagram)       |
|         [6.3 Class Diagram](#63-class-diagram)       |
|         [6.4 Entity Relationship Diagram](#64-entity-relationship-diagram)       |
| |



## 1. Introduction

This program is a mobile application designed as a music theory tool for the company Chromatic Method, which presents a unique and fresh way to learn music theory.

#### 1.1 Purpose

The product this SRS describes the requirements for is Chromatica, a mobile application by the company Chromatic Method. It is currently in development, and this document is for developers, project managers, and usability testers to learn about the program.

#### 1.2 Project Scope

Chromatica is a mobile app that allows the user to search and view the musical interrelationships between a given key, chord, or scale. It contains the algorithms that govern how chords and scales are built, and contains the systematic and detailed information of western music theory. Chromatica relates to both user and corporate goals. The end user will be music educators, students, and composers. This app assists in the teaching, learning, and creation of music, and as such is able to help the users meet their individual goals. It relates to the business objective of Chromatic Method in that it presents a third-party platform that music schools can use to supplement their curriculum.

#### 1.3 References

- [_Xamarin Forms_](https://developer.xamarin.com) _– Platform_
- [_Material Design_](https://material.io/guidelines/) _– Design language_

## 2. Overall Description

This section describes the environment the application will run in, anticipated user classes, and an overview of the product.


#### 2.1 Product Perspective

This is a new product designed to fill a market need for comprehensive music theory systems in the private and public music education sectors. It will use a subscription-based business model, with a monthly charge per user. As an app tailored to the education world, it will be marketed towards the classroom as an extracurricular resource.

#### 2.2 User Classes and Characteristics

There are three primary user classes that are being anticipated to use this product. These classes are music educators, music students, and composers. Characteristics of the music educator include a current high-level knowledge of the ideas the app is based on. Because of this, they will use the program more as a way to show the result of an idea, rather than learn that concept themselves. The student will be coming in with limited or no knowledge, and as such will use the app as a way to get a result for something they cannot figure out themselves. The third class is composers, who will use the app as a resource to generate ideas and better visualize musical concepts. The favored user class is the teacher, as the goal is for the app to become a widespread extracurricular program in the music classroom.

#### 2.3 Operating Environment

The software will operate in an iOS and Android environment, on the current versions (iOS 11 and Android 8 &quot;Oreo&quot;) of both platforms. The geographical location of users will primarily be in the United States, although the universality of the musical language will allow it to be used in any country. The first iteration of the app will be in English however, although later versions will add more technical support. The application will operate entirely offline and as such there are no Internet network connectivity requirements beyond the initial installation.

## 3. System Features

The system features of the application are listed below

### 3.1 Key Analyzer

#### 3.1.1 Description

This feature allows the user to input a key and get a return of all the musical relationships within that key, including the major scale, a chord scale, and the modes in the key.

#### 3.1.2        Stimulus/Response Sequences

The user action that will stimulate the return is navigating to the key analyzer tab at the bottom of the application, taping in the text entry input bar, and imputing a key in the string: &#39;C,D,E,F,G,A,B&#39; with an optional sharp(#) or flat(b) attached. This will return the major scale, modes, and chords in that key.

### 3.2 Chord Finder

#### 3.2.1        Description

This feature allows the user to enter any chord and get a return of the notes that comprise it and the scale it corresponds to.

#### 3.2.2        Stimulus/Response Sequences

The user action that will stimulate the return is navigating to the chord finder tab at the bottom of the application, taping in the text entry input bar, and imputing a chord in the string: &#39;C,D,E,F,G,A,B&#39; with an optional sharp(#) or flat(b) attached. They can also attach one of the string: &#39;7,maj7,m7,9,maj9,m9,sus2,sus4,11,13, diminished, augmented&#39;. This will return the notes associated with the inputted chord.

### 3.3 Scale Finder

#### 3.3.1        Description

This feature allows the user to input a scale and get a return of the scale and modes of it.

#### 3.3.2        Stimulus/Response Sequences

The user action that will stimulate the return is navigating to the scale finder tab at the bottom of the application, taping in the text entry input bar, and imputing a key in the string: &#39;C,D,E,F,G,A,B&#39; with an optional sharp(#) or flat(b) attached. This will return the notes of the key and the modes associated with it.

## 4. External Interface Requirements

This lays out information about the external user interface required by the system.

#### 4.1 User Interfaces

The user interface of this application will feature a standard navigation bar at the bottom of the screen with the following tabs: Key Analyzer, Chord Finder, Scale Finder, About. Each of the first three will contain a brief description of what the tool does, and an input box for the user to enter their search query into. One the user enters their input, the subsequent screen will have a the name of the chord, key, or scale, a diagram of the musical relationship of that element to the rest of the key, and an image of the notation.

## 5. Quality Attributes

#### 5.1 Usability

This software will be user-friendly in the logical organization of the user interface, easy to learn and search for needed information, and aesthetically pleasing based on Google&#39;s Material Design language

#### 5.2 Performance

This application is relatively lightweight, and as such will perform well even on older devices. It does not require Internet accessibility and does not interact with other applications or have any unique dependencies.

## 6. UML Diagrams 

This section contains UML diagrams describing various aspects of The Chromatic Method
application, and contains the following diagrams. The use case diagram illustrates the interaction of
actors with the application; the component diagram shows the interaction of the components with each
other, the class diagram shows the interrelationship of classes and their functions, and the entity
relationship diagram illustrates the relationship between the various entities of the application. Each
section will have both the diagram and a paragraph describing its contents.

#### 6.1 Use Case Diagram

The diagram below presents the three user classes that interact with the system: Students, Educators,
and Composers, and a system ‘user’ the Messaging Handler. The student exclusively interacts with a
student login page, and can use a built-in messaging function to communicate with an educator. The
composer, which is a non-registered user of the application, interacts with the three primary functions
within the application, the key analyzer, the chord finder, and the scale finder. This user can also save
ideas he or she draws from the scales and chords they generate. The educator interacts with a teacher
login, can message their students, view student activity, and set up assignments for them to perform.
Both the students and teachers can also access the three main functions of the application.

Image Here

|   |  |
| ------------- | ------------- |
| Use Case    | 1. The_Chromatic_Method __history__: created 3/6/18 by Jared Forth | |
| Description    | Generates the musical relationships ina key, finds scales and chords based on user input  |
| Actors    | Educator (Primary), Student, Composers  |
| Assumptions    | Generative algorithms can return all musical relationships in a given key  |
| Issues    | Teachers and students save ideas in addition to the composer?  |

##### Steps

* User login as teacher or student or
skips login
* Can perform one of the following
actions:
  - View or send a message
  - Assign (educator) or view
(student) a practice
  - Access key analyzer
  - Access chord finder
  - Access scale finder
* Save ideas
* Exit application




#### 6.2 Component Diagram

The component diagram illustrates the interaction of components and is structured based on the user
interface, functions that can be used, and the infrastructure/ logic behind those functions. The three user
interface screens are the user login screen, which students and teachers can use to login and which can
optionally be skipped by normal users. The key analyzer screen is the primary home interface on the
application, and the scale/chord finder is the secondary interface that can be navigated to. The user
management function regulates the login interface, the analysis function that of the key analyzer, and
the chord and scale finder functions for the corresponding finder interface. User logic regulates the
management of users and controls how they are allowed to interact with each other. The analyzer and
chord and scale finder logic uses slightly different algorithms to return information based on the user
input.

#### 6.3 Class Diagram 

The class diagram presents the classes in the application logic, and has the Composer, Educator, and
Student, which are particular instances of the general class User. The Login class allows students and
educators to login and view details specific to their account. The LoginPage class allows the user to
send a message or view/assign a practice, depending on the type of account the user has. The
StudentMenu and TeacherMenu classes regulate the function of these actions. The Composer class
regulates the actions of a user that is not logged in to the application. The three primary logical functions
of the application are found in the Analyzer, ChordFinder, and ScaleFinder classes, which contain the
logic for the function of the application. The algorithms that return what the user is looking for are
contained in these classes. The SaveIdea class allows the user to save snippets they have generated,
and the three primary classes are accessible by all users.

#### 6.4 Entity Relationship Diagram

The entity relationship diagram presents the relationship between entities of the application and the ratio
by which they can interact with one another. Many users can access any of the functions at any time,
and this applies to all users. The particular instance of user, one educator, can teach many students, but
each student only relates to one teacher. Many composers can save many ideas, and both educators
and students can access all of the functions.
