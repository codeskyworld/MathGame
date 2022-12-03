import "./App.css";
import { Form, FormGroup, Label, Input, Col } from "reactstrap";
import React, { useState, useEffect } from "react";
import { constants } from "./Constants";
import imgQuestionMark from "./images/mark-question.png";
import phone1 from "./images/phone1.png";
import phone2 from "./images/phone2.png";
import phone3 from "./images/phone3.png";
import labtop1 from "./images/labtop1.jpg";
import labtop2 from "./images/labtop2.jpg";
import labtop3 from "./images/labtop3.jpg";
import car1 from "./images/car1.png";
import car2 from "./images/car2.png";
import car3 from "./images/car3.png";
import house1 from "./images/house1.jpg";
import house2 from "./images/house2.jpeg";
import house3 from "./images/house3.jpg";
import girlfriend1 from "./images/girlfriend1.jpg";
import girlfriend2 from "./images/girlfriend2.jpg";
import girlfriend3 from "./images/girlfriend3.jpg";

function App() {
  const [instruction, setInstruction] = useState(
    "Please input your 'Name' and press 'Submit' button to win below gift!"
  );
  const [count, setCount] = useState(0);
  const [arrayTry, setArrayTry] = useState([]);
  const [inputWord, setInputWord] = useState("");
  const [randomFirstIndex, setRandomFirstIndex] = useState(0);
  const [randomSecondIndex, setRandomSecondIndex] = useState(0);
  const [randomThirdIndex, setRandomThirdIndex] = useState(0);
  const [randomFourthIndex, setRandomFourthIndex] = useState(0);
  const [randomFifthIndex, setRandomFifthIndex] = useState(0);
  const [score, setScore] = useState(0);
  const [name, setName] = useState(0);
  const [lockinput, setLockinput] = useState(false);

  const [answerArray, setAnswerArray] = useState([]);
  const [indexFirstDisplay, setIndexFirstDisplay] = useState(false);
  const [indexSecondDisplay, setIndexSecondDisplay] = useState(false);
  const [indexThirdDisplay, setIndexThirdDisplay] = useState(false);
  const [indexFourthDisplay, setIndexFourthDisplay] = useState(false);
  const [indexFifthDisplay, setIndexFifthDisplay] = useState(false);

  const phone = [phone1, phone2, phone3];
  const labtop = [labtop1, labtop2, labtop3];
  const car = [car1, car2, car3];
  const house = [house1, house2, house3];
  const girlfriend = [girlfriend1, girlfriend2, girlfriend3];

  useEffect(() => {
    GetNumberHandler();
  }, []);

  const AssignValue = (e) => {
    setArrayTry([
      `${e[0][0]} + ? = ${e[0][2]}`,
      `${e[1][0]} - ? = ${e[1][2]}`,
      `${e[2][0]} x ? = ${e[2][2]}`,
      `${e[3][0]} ÷ ? = ${e[3][2]}`,
      `( ${e[4][0]} + ? ) x ( ${e[4][2]} - ${e[4][3]} ）÷ 4 = ${e[4][4]}`,
    ]);
    setAnswerArray([
      `${e[0][1]}`,
      `${e[1][1]}`,
      `${e[2][1]}`,
      `${e[3][1]}`,
      `${e[4][1]}`,
    ]);
  };

  const GetNumberHandler = async (e) => {
    fetch(constants.API_URL + "number", {
      method: "GET",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json",
      },
    })
      .then((res) => res.json())
      .then((response) => {
        AssignValue(response);
      });
  };

  const ClearHandler = async (e) => {
    e.preventDefault();
    document.getElementById("inputValue").value = "";
    setInputWord("");
    if(count >= 7){
      window.location.reload(false);
    }
    
  };

  const SubmitHandler = async (e) => {
    e.preventDefault();
    if (inputWord === "" && count === 0) {
      alert("Sorry, please input your name!");
      return;
    } else if (inputWord === "" && count > 0 && count < 6) {
      alert("Sorry, please input integer number!");
      return;
    }
    if (count < 5) {
      setInstruction(arrayTry[count]);
    }
    document.getElementById("inputValue").value = "";

    if (count === 0) {
      setName(inputWord.toString());
    }

    if (count === 1) {
      setIndexFirstDisplay(
        inputWord.toString() === answerArray[count - 1].toString()
          ? true
          : false
      );
      setRandomFirstIndex(Math.floor(Math.random() * 3));
      if (inputWord.toString() !== answerArray[0].toString()) {
        alert(
          `Sorry, incorrect answer! The correct answer is the integer of ${answerArray[0]} !`
        );
      } else {
        setScore(score + 20);
      }
    } else if (count === 2) {
      setIndexSecondDisplay(
        inputWord.toString() === answerArray[count - 1].toString()
          ? true
          : false
      );
      setRandomSecondIndex(Math.floor(Math.random() * 3));
      if (inputWord.toString() !== answerArray[1].toString()) {
        alert(
          `Sorry, incorrect answer! The correct answer is the integer of ${answerArray[1]} !`
        );
      } else {
        setScore(score + 20);
      }
    } else if (count === 3) {
      setIndexThirdDisplay(
        inputWord.toString() === answerArray[count - 1].toString()
          ? true
          : false
      );
      setRandomThirdIndex(Math.floor(Math.random() * 3));
      if (inputWord.toString() !== answerArray[2].toString()) {
        alert(
          `Sorry, incorrect answer! The correct answer is the integer of  ${answerArray[2]} !`
        );
      } else {
        setScore(score + 20);
      }
    } else if (count === 4) {
      setIndexFourthDisplay(
        inputWord.toString() === answerArray[count - 1].toString()
          ? true
          : false
      );
      setRandomFourthIndex(Math.floor(Math.random() * 3));
      if (inputWord.toString() !== answerArray[3].toString()) {
        alert(
          `Sorry, incorrect answer! The correct answer is the integer of  ${answerArray[3]} !`
        );
      } else {
        setScore(score + 20);
      }
    } else if (count === 5) {
      setIndexFifthDisplay(
        inputWord.toString() === answerArray[count - 1].toString()
          ? true
          : false
      );
      setRandomFifthIndex(Math.floor(Math.random() * 3));
      if (inputWord.toString() !== answerArray[4].toString()) {
        alert(
          `Sorry, incorrect answer! The correct answer is the integer of  ${answerArray[4]} !`
        );
      } else {
        setScore(score + 20);
      }
      setInstruction(
        `Congratulation! ${name}, You have completed the test. Click 'Submit' button to check grade`
      );
      setLockinput(true);
    } else if (count === 6) {
      setInstruction(
        `You grade is ${score}! Click 'Submit' button to collect ${name}'s gift! Click "Clear" button to restart`
      );
    } else if (count >= 7 && score.toString() !== (0).toString()) {
      window.open(constants.VOLVO_URL, "_blank");
    }else if (count >= 7 && score.toString() === (0).toString()) {
      window.open(constants.MATH_URL, "_blank");
    }

    setCount(count + 1);
    setInputWord("");
  };

  return (
    <div
      id="loginWindow"
      className="container d-flex justify-content-center pb-3"
    >
      <br></br>
      <br></br>
      <br></br>
      <Form sm={12}>
        <br></br>
        <br></br>
        <br></br>
        <div className="text-center">
          <h1 id="loginTitle">Math Game</h1>
          <h3 id="hintTitle">Hint: Answer is the interger of 1 - 100</h3>
        </div>

        <FormGroup row id="inputrow">
          <Label for="number" sm={12} id="contentInstruction">
            {instruction}
          </Label>
          <Col sm={6}>
            <Input
              type="text"
              name="number"
              id="inputValue"
              disabled={lockinput}
              onChange={(event) => {
                setInputWord([event.target.value]);
              }}
            />
          </Col>
        </FormGroup>
        <div className="d-grid text-center gap-3 mt-4">
          <button
            className="btn btn-outline-primary btn-lg w-50"
            onClick={SubmitHandler}
          >
            Submit
          </button>
        </div>
        <div className="d-grid text-center gap-3 mt-3">
          <button
            className="btn btn-outline-danger btn-lg w-50"
            onClick={ClearHandler}
          >
            Clear
          </button>
        </div>

        <div className="row mt-5">
          <div className="col">
            <img
              src={
                indexFirstDisplay ? phone[randomFirstIndex] : imgQuestionMark
              }
              alt="Instagram"
              width="190"
              height="190"
            />
          </div>
          <div className="col">
            <img
              src={
                indexSecondDisplay ? labtop[randomSecondIndex] : imgQuestionMark
              }
              alt="Instagram"
              width="190"
              height="190"
            />
          </div>
          <div className="col">
            <img
              src={indexThirdDisplay ? car[randomThirdIndex] : imgQuestionMark}
              alt="Instagram"
              width="190"
              height="190"
            />
          </div>
          <div className="col">
            <img
              src={
                indexFourthDisplay ? house[randomFourthIndex] : imgQuestionMark
              }
              alt="Instagram"
              width="190"
              height="190"
            />
          </div>
          <div className="col">
            <img
              src={
                indexFifthDisplay
                  ? girlfriend[randomFifthIndex]
                  : imgQuestionMark
              }
              alt="Instagram"
              width="190"
              height="190"
            />
          </div>
        </div>
      </Form>
    </div>
  );
}

export default App;
