import { useEffect, useState } from "react";
import { Bowlers } from "./types/Bowlers";
import { Teams } from "./types/Teams";

// Table of the page
function BowlerData() {
  const [bowlerData, setBowlerData] = useState<Bowlers[]>([]);
  const [teamData, setTeamData] = useState<Teams[]>([]);
  // Gets the data from the bowler controller
  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch("http://localhost:5295/Bowler");
      const f = await rsp.json();
      setBowlerData(f);
    };
    fetchBowlerData();
  }, []);

  // Gets the data from the team controller
  useEffect(() => {
    const fetchTeamData = async () => {
      const rsp = await fetch("http://localhost:5295/Team");
      const f_1 = await rsp.json();
      setTeamData(f_1);
    };
    fetchTeamData();
  }, []);

  return (
    // The actual table
    <div>
      <table className="table table-hover">
        <thead>
          <tr>
            <th>Bowler</th>
            <th>Team</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone #</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((bowler) => (
            <tr key={bowler.BowlerId}>
              <td>
                {bowler.bowlerFirstName} {bowler.bowlerLastName}
              </td>
              <td>
                {
                  teamData.find((team) => team.teamId === bowler.teamId)
                    ?.teamName
                }
              </td>
              <td>{bowler.bowlerAddress}</td>
              <td>{bowler.bowlerCity}</td>
              <td>{bowler.bowlerState}</td>
              <td>{bowler.bowlerZip}</td>
              <td>{bowler.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default BowlerData;
