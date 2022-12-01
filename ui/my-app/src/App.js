import "./App.css";
import { Form, FormGroup, Label, Input, Col } from "reactstrap";
import React, { useState } from "react";
import { constants } from "./Constants";

function App() {
  const [number, setNumber] = useState("");
  const [words, setWords] = useState("");

  const ProcessHandler = async (e) => {
    e.preventDefault();
    fetch(constants.API_URL + "number/" + number, {
      method: "POST",
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json",
      },
    })
      .then((res) => res.json())
      .then(
        (result) => {
          setWords(result);
        },
        (error) => {
          alert("Failded");
        }
      );
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
      .then((response) => console.log(response));
    // .then((data) => console.log(data));
  };

  GetNumberHandler();

  const ClearHandler = async (e) => {
    e.preventDefault();
    setNumber("");
    setWords("");
  };

  return (
    <div
      id="loginWindow"
      className="container d-flex justify-content-center pb-3"
    >
      <br></br>
      <br></br>
      <br></br>
      <Form>
        <br></br>
        <br></br>
        <br></br>
        <div className="text-center">
          <h1 id="loginTitle">Number To Words</h1>
        </div>
        <FormGroup row>
          <Label for="number" sm={4}>
            Number
          </Label>
          <Col sm={12}>
            <Input
              type="text"
              name="number"
              id="number"
              value={number}
              onChange={(event) => {
                setNumber(event.target.value);
              }}
            />
          </Col>
        </FormGroup>
        <FormGroup row>
          <Label for="result" sm={5}>
            Words Result
          </Label>
          <Col sm={12}>
            <div
              id="resultbar"
              className="alert alert-primary"
              role="alert"
              value={number}
            >
              {words}
            </div>
          </Col>
        </FormGroup>
        <div className="d-grid gap-3 mt-5">
          <button
            className="btn btn-outline-primary btn-lg w-100"
            onClick={ProcessHandler}
          >
            Convert
          </button>
        </div>

        <div className="d-grid gap-3 mt-3">
          <button
            className="btn btn-outline-danger btn-lg w-100"
            onClick={ClearHandler}
          >
            Clear
          </button>
        </div>
      </Form>
    </div>
  );
}

export default App;
