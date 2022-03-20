import React, { Component } from 'react';

export class Home extends Component {
  static displayName = "WebJournal";

  render () {
    return (
        <>
            <div className="bg-dark text-secondary">
                <div className="py-5">
                    <h1 className="display-5 text-center text-white">WebJournal [Tabloid]</h1>
                    <div className="col-lg-6 mx-auto">
                        <p className="fs-5 ">Share your thoughts and Knowledge, Learn different perspective!</p>
                        <div className="d-grid gap-2 d-sm-flex justify-content-sm-center">
                            <button type="button" className="btn btn-outline-info btn-lg px-4 me-sm-3 fw-bold">Learn More</button>
                            <button type="button" className="btn btn-outline-light btn-lg px-4">Sign up</button>
                        </div>
                    </div>
                </div>
            </div>

            <div className="row mt-5">
                <div className="col-md-4">
                    <h2>Heading</h2>
                    <p>Will you do the same for me? It's time to face the music I'm no longer your muse. Heard it's beautiful, be the judge and my girls gonna take a vote. I can feel a phoenix inside of me. Heaven is jealous of our love, angels are crying from up above. Yeah, you take me to utopia.</p>
                    <p><a className="btn btn-secondary" href="#" role="button">View details »</a></p>
                </div>
                <div className="col-md-4">
                    <h2>Heading</h2>
                    <p>Standing on the frontline when the bombs start to fall. Heaven is jealous of our love, angels are crying from up above. Can't replace you with a million rings. Boy, when you're with me I'll give you a taste. There’s no going back. Before you met me I was alright but things were kinda heavy. Heavy is the head that wears the crown.</p>
                    <p><a className="btn btn-secondary" href="#" role="button">View details »</a></p>
                </div>
                <div className="col-md-4">
                    <h2>Heading</h2>
                    <p>Playing ping pong all night long, everything's all neon and hazy. Yeah, she's so in demand. She's sweet as pie but if you break her heart. But down to earth. It's time to face the music I'm no longer your muse. I guess that I forgot I had a choice.</p>
                    <p><a className="btn btn-secondary" href="#" role="button">View details »</a></p>
                </div>
            </div>

            <footer class="container">
                <p>© WebJournal 2022</p>
            </footer>
      </>
    );
  }
}
