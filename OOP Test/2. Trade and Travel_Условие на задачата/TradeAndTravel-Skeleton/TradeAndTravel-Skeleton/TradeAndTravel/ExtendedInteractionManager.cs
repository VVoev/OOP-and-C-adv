﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class ExtendedInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    return new Weapon(itemNameString, itemLocation);
                case "wood":
                    return new Wood(itemNameString, itemLocation);
                case "iron":
                    return new Iron(itemNameString, itemLocation);
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }
        }
        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            switch (locationTypeString)
            {
                case "mine":
                    return new Mine(locationName);
                case "forest":
                    return new Forest(locationName);
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }            
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    this.HandleGatherInteraction(actor,commandWords[2]);
                    break;
                default:
                        base.HandlePersonCommand(commandWords, actor); break;
            }
                  
        }

        private void HandleGatherInteraction(Person actor,string itemName)
        {
            if (actor.Location.LocationType == LocationType.Forest
                && actor.ListInventory().Any(x => x.ItemType == ItemType.Weapon))
            {
                AddToPerson(actor, new Wood(itemName));
            }
            if (actor.Location.LocationType == LocationType.Mine
                && actor.ListInventory().Any(x => x.ItemType == ItemType.Armor))
            {
                AddToPerson(actor, new Iron(itemName));
            }
               

            }
        }
    }
