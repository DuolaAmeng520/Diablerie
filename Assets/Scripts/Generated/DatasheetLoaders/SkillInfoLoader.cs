
// It's generated file. DO NOT MODIFY IT!
class SkillInfoLoader : Datasheet.Loader<SkillInfo>
{

    public void LoadRecord(ref SkillInfo record, Datasheet.Stream stream)
    {
                Datasheet.Parse(stream.NextString(), ref record.skill);
                Datasheet.Parse(stream.NextString(), ref record.id);
                Datasheet.Parse(stream.NextString(), ref record.charClass);
                Datasheet.Parse(stream.NextString(), ref record.skillDescId);
                Datasheet.Parse(stream.NextString(), ref record.srvStartFunc);
                Datasheet.Parse(stream.NextString(), ref record.srvDoFunc);
                record.unused = new string[54];
                    Datasheet.Parse(stream.NextString(), ref record.unused[0]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[1]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[2]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[3]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[4]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[5]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[6]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[7]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[8]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[9]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[10]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[11]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[12]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[13]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[14]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[15]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[16]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[17]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[18]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[19]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[20]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[21]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[22]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[23]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[24]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[25]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[26]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[27]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[28]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[29]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[30]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[31]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[32]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[33]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[34]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[35]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[36]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[37]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[38]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[39]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[40]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[41]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[42]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[43]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[44]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[45]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[46]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[47]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[48]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[49]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[50]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[51]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[52]);
                    Datasheet.Parse(stream.NextString(), ref record.unused[53]);
                Datasheet.Parse(stream.NextString(), ref record.summon);
                Datasheet.Parse(stream.NextString(), ref record.pettype);
                Datasheet.Parse(stream.NextString(), ref record.petmax);
                Datasheet.Parse(stream.NextString(), ref record.summode);
                record.sumcalcs = new string[10];
                    Datasheet.Parse(stream.NextString(), ref record.sumcalcs[0]);
                    Datasheet.Parse(stream.NextString(), ref record.sumcalcs[1]);
                    Datasheet.Parse(stream.NextString(), ref record.sumcalcs[2]);
                    Datasheet.Parse(stream.NextString(), ref record.sumcalcs[3]);
                    Datasheet.Parse(stream.NextString(), ref record.sumcalcs[4]);
                    Datasheet.Parse(stream.NextString(), ref record.sumcalcs[5]);
                    Datasheet.Parse(stream.NextString(), ref record.sumcalcs[6]);
                    Datasheet.Parse(stream.NextString(), ref record.sumcalcs[7]);
                    Datasheet.Parse(stream.NextString(), ref record.sumcalcs[8]);
                    Datasheet.Parse(stream.NextString(), ref record.sumcalcs[9]);
                Datasheet.Parse(stream.NextString(), ref record.sumumod);
                Datasheet.Parse(stream.NextString(), ref record.sumoverlay);
                Datasheet.Parse(stream.NextString(), ref record.stsuccessonly);
                Datasheet.Parse(stream.NextString(), ref record._stsound);
                record.unused2 = new string[10];
                    Datasheet.Parse(stream.NextString(), ref record.unused2[0]);
                    Datasheet.Parse(stream.NextString(), ref record.unused2[1]);
                    Datasheet.Parse(stream.NextString(), ref record.unused2[2]);
                    Datasheet.Parse(stream.NextString(), ref record.unused2[3]);
                    Datasheet.Parse(stream.NextString(), ref record.unused2[4]);
                    Datasheet.Parse(stream.NextString(), ref record.unused2[5]);
                    Datasheet.Parse(stream.NextString(), ref record.unused2[6]);
                    Datasheet.Parse(stream.NextString(), ref record.unused2[7]);
                    Datasheet.Parse(stream.NextString(), ref record.unused2[8]);
                    Datasheet.Parse(stream.NextString(), ref record.unused2[9]);
                Datasheet.Parse(stream.NextString(), ref record.castOverlayId);
                Datasheet.Parse(stream.NextString(), ref record.clientOverlayA);
                Datasheet.Parse(stream.NextString(), ref record.clientOverlayB);
                Datasheet.Parse(stream.NextString(), ref record.clientStartFunc);
                Datasheet.Parse(stream.NextString(), ref record.clientDoFunc);
                Datasheet.Parse(stream.NextString(), ref record.clientPrqFunc1);
                Datasheet.Parse(stream.NextString(), ref record.clientPrqFunc2);
                Datasheet.Parse(stream.NextString(), ref record.clientPrqFunc3);
                Datasheet.Parse(stream.NextString(), ref record.clientMissile);
                Datasheet.Parse(stream.NextString(), ref record.clientMissileA);
                Datasheet.Parse(stream.NextString(), ref record.clientMissileB);
                Datasheet.Parse(stream.NextString(), ref record.clientMissileC);
                Datasheet.Parse(stream.NextString(), ref record.clientMissileD);
                record.clientCalcs = new string[6];
                    Datasheet.Parse(stream.NextString(), ref record.clientCalcs[0]);
                    Datasheet.Parse(stream.NextString(), ref record.clientCalcs[1]);
                    Datasheet.Parse(stream.NextString(), ref record.clientCalcs[2]);
                    Datasheet.Parse(stream.NextString(), ref record.clientCalcs[3]);
                    Datasheet.Parse(stream.NextString(), ref record.clientCalcs[4]);
                    Datasheet.Parse(stream.NextString(), ref record.clientCalcs[5]);
                Datasheet.Parse(stream.NextString(), ref record.warp);
                Datasheet.Parse(stream.NextString(), ref record.immediate);
                Datasheet.Parse(stream.NextString(), ref record.enhanceable);
                Datasheet.Parse(stream.NextString(), ref record.attackRank);
                Datasheet.Parse(stream.NextString(), ref record.noAmmo);
                Datasheet.Parse(stream.NextString(), ref record._range);
                Datasheet.Parse(stream.NextString(), ref record.weapSel);
                Datasheet.Parse(stream.NextString(), ref record.itemTypeA1);
                Datasheet.Parse(stream.NextString(), ref record.itemTypeA2);
                Datasheet.Parse(stream.NextString(), ref record.itemTypeA3);
                Datasheet.Parse(stream.NextString(), ref record.eItemTypeA1);
                Datasheet.Parse(stream.NextString(), ref record.eItemTypeA2);
                Datasheet.Parse(stream.NextString(), ref record.itemTypeB1);
                Datasheet.Parse(stream.NextString(), ref record.itemTypeB2);
                Datasheet.Parse(stream.NextString(), ref record.itemTypeB3);
                Datasheet.Parse(stream.NextString(), ref record.eItemTypeB1);
                Datasheet.Parse(stream.NextString(), ref record.eItemTypeB2);
                Datasheet.Parse(stream.NextString(), ref record.anim);
                Datasheet.Parse(stream.NextString(), ref record.seqTrans);
                Datasheet.Parse(stream.NextString(), ref record.monAnim);
                Datasheet.Parse(stream.NextString(), ref record.seqNum);
                Datasheet.Parse(stream.NextString(), ref record.seqInput);
                Datasheet.Parse(stream.NextString(), ref record.durability);
                Datasheet.Parse(stream.NextString(), ref record.useAttackRate);
                Datasheet.Parse(stream.NextString(), ref record.lineOfSight);
                Datasheet.Parse(stream.NextString(), ref record.targetableOnly);
                Datasheet.Parse(stream.NextString(), ref record.searchEnemyXY);
                Datasheet.Parse(stream.NextString(), ref record.searchEnemyNear);
                Datasheet.Parse(stream.NextString(), ref record.searchOpenXY);
                Datasheet.Parse(stream.NextString(), ref record.selectProc);
                Datasheet.Parse(stream.NextString(), ref record.targetCorpse);
                Datasheet.Parse(stream.NextString(), ref record.targetPet);
                Datasheet.Parse(stream.NextString(), ref record.targetAlly);
                Datasheet.Parse(stream.NextString(), ref record.targetItem);
                record.unused3 = new string[77];
                    Datasheet.Parse(stream.NextString(), ref record.unused3[0]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[1]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[2]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[3]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[4]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[5]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[6]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[7]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[8]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[9]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[10]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[11]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[12]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[13]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[14]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[15]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[16]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[17]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[18]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[19]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[20]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[21]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[22]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[23]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[24]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[25]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[26]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[27]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[28]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[29]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[30]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[31]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[32]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[33]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[34]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[35]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[36]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[37]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[38]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[39]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[40]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[41]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[42]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[43]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[44]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[45]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[46]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[47]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[48]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[49]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[50]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[51]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[52]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[53]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[54]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[55]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[56]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[57]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[58]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[59]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[60]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[61]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[62]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[63]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[64]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[65]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[66]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[67]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[68]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[69]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[70]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[71]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[72]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[73]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[74]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[75]);
                    Datasheet.Parse(stream.NextString(), ref record.unused3[76]);
                Datasheet.Parse(stream.NextString(), ref record.hitShift);
                Datasheet.Parse(stream.NextString(), ref record.srcDamage);
                Datasheet.Parse(stream.NextString(), ref record.minDamage);
                record.minDamagePerLevel = new int[5];
                    Datasheet.Parse(stream.NextString(), ref record.minDamagePerLevel[0]);
                    Datasheet.Parse(stream.NextString(), ref record.minDamagePerLevel[1]);
                    Datasheet.Parse(stream.NextString(), ref record.minDamagePerLevel[2]);
                    Datasheet.Parse(stream.NextString(), ref record.minDamagePerLevel[3]);
                    Datasheet.Parse(stream.NextString(), ref record.minDamagePerLevel[4]);
                Datasheet.Parse(stream.NextString(), ref record.maxDamage);
                record.maxDamagePerLevel = new int[5];
                    Datasheet.Parse(stream.NextString(), ref record.maxDamagePerLevel[0]);
                    Datasheet.Parse(stream.NextString(), ref record.maxDamagePerLevel[1]);
                    Datasheet.Parse(stream.NextString(), ref record.maxDamagePerLevel[2]);
                    Datasheet.Parse(stream.NextString(), ref record.maxDamagePerLevel[3]);
                    Datasheet.Parse(stream.NextString(), ref record.maxDamagePerLevel[4]);
                Datasheet.Parse(stream.NextString(), ref record.damageSymPerCalc);
                Datasheet.Parse(stream.NextString(), ref record.eType);
                Datasheet.Parse(stream.NextString(), ref record.eMin);
                record.minEDamagePerLevel = new int[5];
                    Datasheet.Parse(stream.NextString(), ref record.minEDamagePerLevel[0]);
                    Datasheet.Parse(stream.NextString(), ref record.minEDamagePerLevel[1]);
                    Datasheet.Parse(stream.NextString(), ref record.minEDamagePerLevel[2]);
                    Datasheet.Parse(stream.NextString(), ref record.minEDamagePerLevel[3]);
                    Datasheet.Parse(stream.NextString(), ref record.minEDamagePerLevel[4]);
                Datasheet.Parse(stream.NextString(), ref record.eMax);
                record.maxEDamagePerLevel = new int[5];
                    Datasheet.Parse(stream.NextString(), ref record.maxEDamagePerLevel[0]);
                    Datasheet.Parse(stream.NextString(), ref record.maxEDamagePerLevel[1]);
                    Datasheet.Parse(stream.NextString(), ref record.maxEDamagePerLevel[2]);
                    Datasheet.Parse(stream.NextString(), ref record.maxEDamagePerLevel[3]);
                    Datasheet.Parse(stream.NextString(), ref record.maxEDamagePerLevel[4]);
                Datasheet.Parse(stream.NextString(), ref record.eDamageSymPerCalc);
                Datasheet.Parse(stream.NextString(), ref record.eLen);
                record.eLenPerLevel = new int[3];
                    Datasheet.Parse(stream.NextString(), ref record.eLenPerLevel[0]);
                    Datasheet.Parse(stream.NextString(), ref record.eLenPerLevel[1]);
                    Datasheet.Parse(stream.NextString(), ref record.eLenPerLevel[2]);
                Datasheet.Parse(stream.NextString(), ref record.eLenSymPerCalc);
                Datasheet.Parse(stream.NextString(), ref record.aiType);
                Datasheet.Parse(stream.NextString(), ref record.aiBonus);
                Datasheet.Parse(stream.NextString(), ref record.costMult);
                Datasheet.Parse(stream.NextString(), ref record.costAdd);
    }
}
